using AutoMapper;
using Bake.BusinessService.Dtos;
using Bake.BusinessService.Repository;
using Bake.DataService.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bake.Controller
{
    
    [ApiController]
    public class BakedController: ControllerBase

    {
        private readonly ICustomerRepo _customer;
        private readonly IItemRepo _item;
        private readonly IOrderRepo _order;
        private readonly IMapper _mapper;

        public BakedController(ICustomerRepo customer, IItemRepo item, IOrderRepo order, IMapper mapper )
        {
            _customer = customer;
            _item = item;
            _order = order;
            _mapper = mapper;
        }
        //private readonly CustomerRepo _customer = new CustomerRepo();

        //GET api/customers
        [Route("api/customers")]
        [HttpGet]
        public ActionResult <IEnumerable<CustomerReadDto>> GetAllCustomers()
        {
            var customers = _customer.GetAllCustomers();
            return Ok(_mapper.Map<IEnumerable<CustomerReadDto>>(customers));
             
        }

        //GET api/customers/{id}
        [HttpGet("api/customers/{id}")]
        public ActionResult <CustomerReadDto> GetCustomerById(int id)
        {
            var customer = _customer.GetCustomerById(id);
            if (customer != null)
            {
                return Ok(_mapper.Map<CustomerReadDto>(customer)); 
            }
            return NotFound();

        }

        //POST api/customers
        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var customerModel = _mapper.Map<customer>(customerCreateDto);
            _customer.CreateCustomer(customerModel);
            _customer.SaveChanges();

            var customerReadDto = _mapper.Map<CustomerReadDto>(customerModel);

            return CreatedAtRoute(nameof(GetCustomerById), new { Id = customerReadDto.CustomerId }, customerReadDto);   
        }

        //PUT api/customers/{id}
        [HttpPut("api/customers/{id}")]
        public ActionResult UpdateCustomer(int id, CustomerUpdateDto customerUpdateDto)
        {
            var customerModelFromRepo = _customer.GetCustomerById(id);
            if(customerModelFromRepo==null)
            {
                return NotFound();
            }
            _mapper.Map(customerUpdateDto, customerModelFromRepo);
            _customer.UpdateCustomer(customerModelFromRepo);
            _customer.SaveChanges();
            return NoContent();
        }

        //PATCH api/customers/{id}
        [HttpPatch("api/customers/{id}")]
        public ActionResult PartialCustomerUpdate(int id, JsonPatchDocument<CustomerUpdateDto> patchDoc)
        {
            var customerModelFromRepo = _customer.GetCustomerById(id);
            if (customerModelFromRepo == null)
            {
                return NotFound();
            }

            var customerToPatch = _mapper.Map<CustomerUpdateDto>(customerModelFromRepo);
            patchDoc.ApplyTo(customerToPatch, ModelState);

            if( !TryValidateModel(customerToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(customerToPatch, customerModelFromRepo);
            _customer.UpdateCustomer(customerModelFromRepo);
            _customer.SaveChanges();
            return NoContent();

        }

        //DELETE api/customers/{id}
        [HttpDelete("api/customers/{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customerModelFromRepo = _customer.GetCustomerById(id);
            if (customerModelFromRepo == null)
            {
                return NotFound();
            }

            _customer.DeleteCustomer(customerModelFromRepo);
            _customer.SaveChanges();
            return NoContent();
        }








        //GET api/items
        [HttpGet("api/items")]
        public ActionResult<IEnumerable<ItemReadDto>> GetAllItems()
        {
            var items = _item.GetAllItems();
            return Ok(_mapper.Map<IEnumerable<ItemReadDto>>(items));

        }

        //GET api/items/{id}
        [HttpGet("api/items/{id}")]
        public ActionResult<ItemReadDto> GetItemById(int id)
        {
            var item = _item.GetItemById(id);
            if (item != null)
            {
                return Ok(_mapper.Map<ItemReadDto>(item));
            }
            return NotFound();
        }

        //POST api/items
        [HttpPost("api/items")]
        public ActionResult<ItemReadDto> CreateItem(ItemCreateDto itemCreateDto)
        {
            var itemModel = _mapper.Map<item>(itemCreateDto);
            _item.CreateItem(itemModel);
            _item.SaveChanges();

            var itemReadDto = _mapper.Map<ItemReadDto>(itemModel);

            return CreatedAtRoute(nameof(GetItemById), new { Id = itemReadDto.ItemId }, itemReadDto);

        }

        //PUT api/items/{id}
        [HttpPut("api/items/{id}")]
        public ActionResult UpdateItem(int id, ItemUpdateDto itemUpdateDto)
        {
            var itemModelFromRepo = _item.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(itemUpdateDto, itemModelFromRepo);
            _item.UpdateItem(itemModelFromRepo);
            _item.SaveChanges();
            return NoContent();
        }

        //PATCH api/items/{id}
        [HttpPatch("api/items/{id}")]
        public ActionResult PartialItemUpdate(int id, JsonPatchDocument<ItemUpdateDto> patchDoc)
        {
            var itemModelFromRepo = _item.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }

            var itemToPatch = _mapper.Map<ItemUpdateDto>(itemModelFromRepo);
            patchDoc.ApplyTo(itemToPatch, ModelState);

            if (!TryValidateModel(itemToPatch))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(itemToPatch, itemModelFromRepo);
            _item.UpdateItem(itemModelFromRepo);
            _item.SaveChanges();
            return NoContent();

        }

        //DELETE api/items/{id}
        [HttpDelete("api/items/{id}")]
        public ActionResult DeleteItem(int id)
        {
            var itemModelFromRepo = _item.GetItemById(id);
            if (itemModelFromRepo == null)
            {
                return NotFound();
            }

            _item.DeleteItem(itemModelFromRepo);
            _item.SaveChanges();
            return NoContent();
        }









        //GET api/orders
        [HttpGet("api/orders")]
        public ActionResult<IEnumerable<OrderReadDto>> GetAllOrders()
        {
            var orders = _order.GetAllOrders();
            return Ok(_mapper.Map<IEnumerable<OrderReadDto>>(orders));
        }

        //GET api/orders/{id}
        [HttpGet("api/orders/{id}")]
        public ActionResult<OrderReadDto> GetOrderById(int id)
        {
            var order = _order.GetOrderById(id);
            if (order != null)
            {
                return Ok(_mapper.Map<OrderReadDto>(order));
            }
            return NotFound();
        }

        //POST api/orders
        [HttpPost("api/orders")]
        public ActionResult<OrderReadDto> CreateOrder(OrderCreateDto orderCreateDto)
        {
            var orderModel = _mapper.Map<order>(orderCreateDto);
            _order.CreateOrder(orderModel);
            _order.SaveChanges();

            var orderReadDto = _mapper.Map<OrderReadDto>(orderModel);
            return CreatedAtRoute(nameof(GetOrderById), new { Id = orderReadDto.OrderId }, orderReadDto);
        }

        //PUT api/orders/{id}
        [HttpPut("api/orders/{id}")]
        public ActionResult UpdateOrder(int id, OrderUpdateDto orderUpdateDto)
        {
            var orderModelFromRepo = _order.GetOrderById(id);
            if (orderModelFromRepo == null)
            {
                return NotFound();
            }
            _mapper.Map(orderUpdateDto, orderModelFromRepo);
            _order.UpdateOrder(orderModelFromRepo);
            _order.SaveChanges();
            return NoContent();
        }

        //PATCH api/orders/{id}
        [HttpPatch("api/orders/{id}")]
        public ActionResult PartialOrderUpdate(int id, JsonPatchDocument<OrderUpdateDto> patchDoc)
        {
            var orderModelFromRepo = _order.GetOrderById(id);
            if (orderModelFromRepo == null)
            {
                return NotFound();
            }

            var orderToPatch = _mapper.Map<OrderUpdateDto>(orderModelFromRepo);
            patchDoc.ApplyTo(orderToPatch, ModelState);

            if (!TryValidateModel(orderToPatch))
            {
                return ValidationProblem(ModelState);
            }
            _mapper.Map(orderToPatch, orderModelFromRepo);
            _order.UpdateOrder(orderModelFromRepo);
            _order.SaveChanges();
            return NoContent();
        }

        //DELETE api/orders/{id}
        [HttpDelete("api/orders/{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var orderModelFromRepo = _order.GetOrderById(id);
            if (orderModelFromRepo == null)
            {
                return NotFound();
            }

            _order.DeleteOrder(orderModelFromRepo);
            _order.SaveChanges();
            return NoContent();
        }
    }
}
