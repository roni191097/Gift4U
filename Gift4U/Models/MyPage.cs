using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Gift4U.Models
{
    public class MyPage

    {
        [Key]
        public int Id { get; set; }
       
        public User MyUser { get; set; }
        
        public List<Order> MyOrders { get; set; }
        
        public MyPage()
        {
            MyOrders = new List<Order>();
        }


    }
   
}

