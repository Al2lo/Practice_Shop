using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PracticeShop.DAL.Data.Repositories;
using PracticeShop.DAL.Entities;
using PracticeShop.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.DAL.Data
{
    public class UnitOfWork
    {
        CategoryRepository categoryRepository {  get; set; }
        OrderItemRepository orderItemRepository { get; set; }
        OrderRepository orderRepository { get; set; }
        ProductRepository productRepository { get; set; }
        UserRepository userRepository { get; set; }

        ApplicationContext applicationContext { get; set; }

        public UnitOfWork (ApplicationContext context)
        {
            applicationContext = context;

            categoryRepository = new CategoryRepository (applicationContext);
            orderItemRepository = new OrderItemRepository (applicationContext);
            orderRepository = new OrderRepository (applicationContext);
            productRepository = new ProductRepository (applicationContext);
            userRepository = new UserRepository(applicationContext);
        }
    }
}
