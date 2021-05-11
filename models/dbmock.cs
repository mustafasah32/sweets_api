using System.Collections.Generic;

namespace Sweets.Cakes.Models{
    public static class dbmock
    {
        public static List<Cake> Cakes=new List<Cake>(){
            new Cake("0","comment 1","Cake 1","cake.jpg",5),
            new Cake("1","comment 2","Cake 2","cake.jpg",3),
            new Cake("2","comment 3","Cake 3","cake.jpg",2),
            new Cake("3","comment 4","Cake 4","cake.jpg",5),
            new Cake("4","comment 5","Cake 5","cake.jpg",3),
            new Cake("5","comment 6","Cake 6","cake.jpg",2),
        };
    }
}
