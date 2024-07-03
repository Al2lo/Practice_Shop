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
        private CategoryRepository categoryRepository;
        private OrderItemRepository orderItemRepository;
        private OrderRepository orderRepository;
        private ProductRepository productRepository;
        private UserRepository userRepository;

        CategoryRepository CategoryRepository
        {
            get
            {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(applicationContext);
                return categoryRepository;
            }
        }
            
        OrderItemRepository OrderItemRepository { 
            get 
            {
                if(orderItemRepository == null)
                    orderItemRepository = new OrderItemRepository(applicationContext);
                return orderItemRepository;
            } 
        }

        OrderRepository OrderRepository
        {
            get
            {
                if(orderRepository == null)
                    orderRepository = new OrderRepository(applicationContext);
                return orderRepository;
            }
        }

        ProductRepository ProductRepository
        {
            get
            {
                if(productRepository == null)
                    productRepository = new ProductRepository(applicationContext);
                return productRepository;
            }
        }

        UserRepository UserRepository
        {
            get
            {
                if(userRepository == null)
                    userRepository = new UserRepository(applicationContext);
                return userRepository;
            }
        }

        ApplicationContext applicationContext { get; set; }

        public UnitOfWork (ApplicationContext context)
        {
            applicationContext = context;

        }
    }
}
