using System.ComponentModel.DataAnnotations;

namespace MICE.Domain.Entities
{
    public class User
    {
        [Key]
        public int ID { get; set; }                     
        public string Login { get; set; }               
        public string Password { get; set; }             
        public string Rules { get; set; }  

        public string Surname { get; set; }   //фамилия
        public string Name { get; set; }      //Имя
        public string MName { get; set; }     //отчество

        public string Telephone { get; set; }
        public string Email { get; set; }

        // public string TitleEvent { get; set; }         
        /* public string FieldOfActivity { get; set; }    //Сфера деятельности
         public string Country { get; set; }              //Страна
         public string Company { get; set; }              //Компания
         public string WebSite { get; set; }              //Веб-сайт
         public string CompanyDescription { get; set; }   //Описание компании
         public string Adress { get; set; }               //Адрес
         public string Telephone { get; set; }            //Телефон
         public string Fax { get; set; }                  //Факс
         public string BankAddress { get; set; }          //Банковский адрес
         public string BankingDetails { get; set; }       //Банковские детали
         public string NameOnThePlate { get; set; }       //Имя на табличке
         public string Email { get; set; }                //Адрес электронной почты для связи
         public string Surname { get; set; }              //Фамилия
         public string Name { get; set; }                 //Имя
         public string Patronymic { get; set; }           //Отчество
         public string Position { get; set; }             //Должность*/


    }
}
