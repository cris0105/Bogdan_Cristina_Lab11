using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogdan_Cristina_Lab11.Models;

namespace Bogdan_Cristina_Lab11.Data
{
    public interface IRestService
    {
        List<ShopList> Items { get; }

        Task<List<ShopList>> RefreshDataAsync();
        Task SaveShopListAsync(ShopList item, bool isNewItem);
        Task DeleteShopListAsync(int id);
    }
}
