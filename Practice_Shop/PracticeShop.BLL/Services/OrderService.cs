using FluentValidation;
using PracticeShop.BLL.Services.Interfaces;
using PracticeShop.DAL.Data;
using PracticeShop.DAL.Data.Repositories.Interfaces;
using PracticeShop.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeShop.BLL.Services
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<Order> _orderValidator;

        public OrderService(IUnitOfWork unitOfWork, IValidator<Order> orderValidator)
        {
            _unitOfWork = unitOfWork;
            _orderValidator = orderValidator;
        }

        public async Task<Order?> AddOrderAsync(int userId)
        {
            var order = new Order
            {
                UserId = userId,
                Date = DateTime.UtcNow
            };

            var validationResult = await _orderValidator.ValidateAsync(order);
            if (!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            await _unitOfWork.OrderRepository.AddAsync(order);
            int saveResult = await _unitOfWork.SaveChangesAsync();

            if (saveResult > 0)
                return order;
            else
                return null;
        }

        public async Task<bool> DeleteOrderAsync(Guid orderId)
        {
            var order = await _unitOfWork.OrderRepository.GetByIdAsync(orderId);
            if (order != null)
            {
                _unitOfWork.OrderRepository.Remove(order);
                int saveResult = await _unitOfWork.SaveChangesAsync();
                return saveResult > 0;
            }
            return false;
        }

        public async Task<bool> UpdateOrderAsync(Guid orderId, int userId)
        {
            var order = await _unitOfWork.OrderRepository.GetByIdAsync(orderId);
            if (order != null)
            {
                order.UserId = userId;
                var validationResult = await _orderValidator.ValidateAsync(order);
                if (!validationResult.IsValid)
                {
                    throw new ValidationException(validationResult.Errors);
                }

                _unitOfWork.OrderRepository.Update(order);
                int saveResult = await _unitOfWork.SaveChangesAsync();
                return saveResult > 0;
            }
            return false;
        }
    }
}
