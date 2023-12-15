using Osorio14.DataContext;
using Osorio14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Osorio14.Services
{
    public class CompraService
    {
        private readonly AppDbContext _context;

        public CompraService() => _context = App.GetContext();


        public bool Create(Compra item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Product.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Compra> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Product.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Compra> Get()
        {
            return _context.Product.ToList();
        }


        public List<Compra> GetByText(string text)
        {
            return _context.Product.Where(x => x.Cliente.Contains(text)).ToList();
        }



    }
}
