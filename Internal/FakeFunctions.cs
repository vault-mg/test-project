using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.Internal
{
    public class SecurityProvider
    {
        /// <summary>
        /// Überprüft das Sicherheitssystem und gibt eine Exception, wenn ein Fehler gefunden wurde
        /// </summary>
        /// <returns></returns>
        public async void InitializeSecuritySystem()
        {
            await Task.Run(() =>
            {

                Random random = new Random();
                var mseconds = random.Next(1, 10) * 1000;
                System.Threading.Thread.Sleep(mseconds);

                if (random.Next(100) == 1)
                    throw new Exception();

            });
        }


        /// <summary>
        /// Gibt den Benutzer zurück oder Null wenn nicht gefunden
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public User GetUser(Guid id)
        {
            if(id == Guid.Parse("7b212e72-2f76-4f83-a4df-faea0fa3fc51"))
            {
                return new User() { Id = Guid.Parse("7b212e72-2f76-4f83-a4df-faea0fa3fc51") };
            }

            return null;
        }

    }
}
