using AutoMapper;
using Hamburgueria.DATA.DTO;
using Hamburgueria.DATA.Interfaces.IServices;
using Hamburgueria.DATA.Models;
using Hamburgueria.DATA.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using Telegram.Bot;
using Telegram.Bot.Polling;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace HamburgueriaTriagem.Controllers
{
    public class TelegramController : Controller
    {
        private readonly IPratosService _pratosService;
        private readonly IMapper _mapper;
        TelegramBotClient botClient = new TelegramBotClient("6898069269:AAE5tYjBWsICV2cVhzXF7moNhqLOrNyK8CU");
        

        public TelegramController(IPratosService pratosService, IMapper mapper)
        {
            _pratosService = pratosService;
            _mapper = mapper;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var cancellantionToken = new CancellationTokenSource();

            botClient.StartReceiving(
                updateHandler: UpdateHandlerAsync,
                pollingErrorHandler: PollingErrorHandlerAsync,
                receiverOptions: new ReceiverOptions
                {
                AllowedUpdates = Array.Empty<UpdateType>()
                },
                cancellationToken: cancellantionToken.Token
            );

            var me = await botClient.GetMeAsync(cancellantionToken.Token);

            //MensagemRetornar("Iniciado");

            AcaiViewModel vm = new()
            {
                
            };
            vm.AdicionaisL.Add(new AcaiAdicionais
            {
                Id = 1,
                Nome = "Banana",
                Quantidade = 2
            });
            vm.AdicionaisL.Add(new AcaiAdicionais
            {
                Id = 2,
                Nome = "Laranja",
                Quantidade = 2
            });
            vm.AdicionaisL.Add(new AcaiAdicionais
            {
                Id = 3,
                Nome = "Leite em Pó",
                Quantidade = 5
            });
            vm.TamanhosL.Add(new AcaiTamanhos
            {
                Id = 1,
                Nome = "Pequeno",
                Preco = 8
            });
            vm.TamanhosL.Add(new AcaiTamanhos
            {
                Id = 2,
                Nome = "Médio",
                Preco = 12
            });
            vm.TamanhosL.Add(new AcaiTamanhos
            {
                Id = 3,
                Nome = "Grande",
                Preco = 20
            });


            return View(vm);
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPedido(string sizeId, string additionalIds)
        {

            MensagemRetornar($"Tamanho do Pedido: {sizeId} - Adicionais: {additionalIds}");

            return RedirectToAction("Index");
        }

        private Task PollingErrorHandlerAsync(ITelegramBotClient botClient, Exception exception, CancellationToken cts)
        {
            Console.WriteLine(exception.Message);
            return Task.CompletedTask;
        }

        private async Task UpdateHandlerAsync(ITelegramBotClient botClient, Update update, CancellationToken cts)
        {
            if(update.Message is not { } message)
                return;

            if(message.Text is not { } messageText)
                return;

            var chatId = message.Chat.Id;

            Console.WriteLine($"Mensagem recebida: {messageText}");

            var sendMessage = await botClient.SendTextMessageAsync(
                    chatId: chatId,
                    text: "Mensagem de resposta",
                    cancellationToken: cts
                );

        }

        private async void MensagemRetornar(string mensagem)
        {

            var sendMessage = await botClient.SendTextMessageAsync(
                   chatId: 6582992719,
                   text: mensagem,
                   cancellationToken: CancellationToken.None
               );
        }
    }
}
