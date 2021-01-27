using GameDemo.Entities;
using GameDemo.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Services
{
    class GamerManager : IGamerService
    {
        private readonly IUserValidationService userValidationService;
        private readonly GameDb gameDb;
        public GamerManager(IUserValidationService _userValidationService, GameDb _gameDb)
        {
            userValidationService = _userValidationService;
            gameDb = _gameDb;
        }

        public void Add(Gamer gamer)
        {
            if (userValidationService.Validate(gamer))
            {
                gameDb.Gamers.Add(gamer);
                Console.WriteLine($"{gamer.UserName} isimli kullanıcı sisteme başarıyla eklendi");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {

            Console.WriteLine($"{gamer.UserName} isimli kullanıcı sistemden başarıyla silindi");
        }
        public void Update(Gamer gamer)
        {

            Console.WriteLine($"{gamer.UserName} isimli kullanıcı bilgileri başarıyla güncellendi.");
        }
    }
}
