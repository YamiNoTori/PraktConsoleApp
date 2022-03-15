using System;
using MyLib.Models;
using MyLib.Controllers;

namespace MyConsoleApp
{


    // Графический юзер интерфейс (GUI)
    class Program   
    {
        static void Main(string[] args)
        {
            
            // debug
            Console.WriteLine("Приветствую! Тут реализован графический интерфейс компании <company>!\n");        
            // при старте инициализируется некий контроллер юзера, позволяющий взаимодействовать с 
            // сущностями пользователей
            UsersController userController = new UsersController();

            // имитация отправки введённых данных (валидных) авторизации
            userController.initUser("IAdmin", "qwerty123");
            userController.initUser("mylogin", "mypassword");
            // имитация отправки введённых данных (НЕ валидных) авторизации (ОШИБКА)
           // userController.initUser("IAdфывфыmin", "qwerty123");
        }
    }
}