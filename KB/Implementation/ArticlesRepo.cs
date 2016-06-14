using DbRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KB.ViewModels;

namespace KB.Implementation
{
    public class ArticlesRepo : IDbRepository
    {
      public List<Article> ArticlesGetAll()
        {
            return new List<Article> {
                new Article() {Id =1,
                    Authors = "Autor 1",
                    Description = "Description 1 " ,
                    KeyWords = "Key1, Key2 ,Key3",
                    Body = "Impuls 1",
                    Title = "Tytul 1",
                    PublishDate = DateTime.Now.AddDays(-1)
                },
                 new Article() {Id =2,
                    Authors = "Autor 2",
                    Description = "Description 2 " ,
                    KeyWords = "Key1, Key2 ,Key3",
                    Body = "Impuls 2",
                    Title = "Tytul 2",
                    PublishDate = DateTime.Now.AddDays(-2)
                 },
                  new Article() {Id =3,
                    Authors = "Autor 3",
                    Description = "Description 3 " ,
                    KeyWords = "Key1, Key2 ,Key3",
                    Body = "Impuls 3",
                    Title = "Tytul 3",
                    PublishDate = DateTime.Now.AddDays(-3)
                  }
           };
        }

        public Article ArticlesgetByID(int id)
        {
           return ArticlesGetAll().Where(a=>a.Id == id).FirstOrDefault();
        }
    }
}