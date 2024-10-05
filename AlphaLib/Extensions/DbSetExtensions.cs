using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Linq;

namespace AlphaLib.Extensions
{
    public static class DbSetExtensions
    {
        public static BindingList<TypeT> ToBindingList<TypeT>(this DbSet<TypeT> dbset) where TypeT : class
        {
            return new BindingList<TypeT>(dbset.ToList());
        }
    }
}
