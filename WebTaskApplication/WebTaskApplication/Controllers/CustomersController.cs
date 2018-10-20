using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebTaskApplication.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebTaskApplication.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Id = 1, Name = "Puja Pramudya", Address = "Jln. A Yani No 669", Company = "Radya Labs Teknologi", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/458905232135565312/v3PFrCLy_400x400.png"});
            customers.Add(new Customer() { Id = 2, Name = "Tito Daniswara", Address = "Jln. A Yani No 669", Company = "CV Anugrah Prima", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/530372486945189889/tj3XQ8xi_400x400.jpeg" });
            customers.Add(new Customer() { Id = 3, Name = "Albi Laga", Address = "Jln. A Yani No 669", Company = "Raion Studio", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/531025242747969536/vhoWFuuD.png" });
            customers.Add(new Customer() { Id = 4, Name = "Faizal Hitobeli", Address = "Jln. A Yani No 669", Company = "PT Master System Informatika", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/2817469495/93109782ad239625a31343dee4f6ddd1_400x400.jpeg" });
            customers.Add(new Customer() { Id = 5, Name = "Rendy Faqot", Address = "Jln. A Yani No 669", Company = "PT BSP Prima", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/731307445604114433/LBUwu6VS.jpg" });
            customers.Add(new Customer() { Id = 6, Name = "Irfan Afif", Address = "Jln. A Yani No 669", Company = "PT IT Bersama", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/3114319086/7385720f1d854e6f1c1163fedb4c348a.jpeg" });
            customers.Add(new Customer() { Id = 7, Name = "Hari Bagus", Address = "Jln. A Yani No 669", Company = "PT Cimanuk Solution", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1418745373/hari.png" });
            customers.Add(new Customer() { Id = 8, Name = "Ade Rifaldi", Address = "Jln. A Yani No 669", Company = "PT Rekadia Solution", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1227963900/IMG-20110125-00063_400x400.jpg" });

            return customers;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer() { Id = 1, Name = "Puja Pramudya", Address = "Jln. A Yani No 669", Company = "Radya Labs Teknologi", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/458905232135565312/v3PFrCLy_400x400.png" });
            customers.Add(new Customer() { Id = 2, Name = "Tito Daniswara", Address = "Jln. A Yani No 669", Company = "CV Anugrah Prima", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/530372486945189889/tj3XQ8xi_400x400.jpeg" });
            customers.Add(new Customer() { Id = 3, Name = "Albi Laga", Address = "Jln. A Yani No 669", Company = "Raion Studio", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/531025242747969536/vhoWFuuD.png" });
            customers.Add(new Customer() { Id = 4, Name = "Faizal Hitobeli", Address = "Jln. A Yani No 669", Company = "PT Master System Informatika", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/2817469495/93109782ad239625a31343dee4f6ddd1_400x400.jpeg" });
            customers.Add(new Customer() { Id = 5, Name = "Rendy Faqot", Address = "Jln. A Yani No 669", Company = "PT BSP Prima", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/731307445604114433/LBUwu6VS.jpg" });
            customers.Add(new Customer() { Id = 6, Name = "Irfan Afif", Address = "Jln. A Yani No 669", Company = "PT IT Bersama", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/3114319086/7385720f1d854e6f1c1163fedb4c348a.jpeg" });
            customers.Add(new Customer() { Id = 7, Name = "Hari Bagus", Address = "Jln. A Yani No 669", Company = "PT Cimanuk Solution", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1418745373/hari.png" });
            customers.Add(new Customer() { Id = 8, Name = "Ade Rifaldi", Address = "Jln. A Yani No 669", Company = "PT Rekadia Solution", PhoneNumber = "08912381923", Latitude = -6.188088, Longitude = 106.7703243, ProfileImageUrl = "https://pbs.twimg.com/profile_images/1227963900/IMG-20110125-00063_400x400.jpg" });

            var customer = customers.Where(item => item.Id == id).FirstOrDefault();
            return customer;
        }

        // POST api/<controller>
        [HttpPost]
        public Customer Post(Customer value)
        {
            try
            {
                return value;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
