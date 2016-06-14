using KB.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbRepository
{
    public interface IDbRepository
    {
        List<Article> ArticlesGetAll();
        Article ArticlesgetByID(int id);
    }
}
