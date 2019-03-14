using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Patient
    {

        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public float Age { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactRelation { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }
        public string Diseases { get; set; }
        public  int IdTexture { get; set; }
        public  int NumSensitivity { get; set; }
        public string Classification { get; set; }
        public string Image { get; set; }
        public string Comments { get; set; }


















        //private int num;
        //private string id;
        //private string firstname;
        //private string lastname;
        //private DateTime dateofbirth;
        //private float age;
        //private string contactname;
        //private string contactphone;
        //private string contactrelation;
        //private float height;
        //private float weight;
        //private string diseases;
        //private int idtexture;
        //private int numsensitivity;
        //private string classification;
        //private string image;
        //private string comments;

        //public int Num  { get => num; set => num = value; }
        //public string Id { get => id; set => id = value; }
        //public string Firstname { get => firstname; set => firstname = value; }
        //public string Lastname { get => lastname; set => lastname = value; }
        //public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        //public float Age { get => age; set => age = value; }
        //public string Contactname { get => contactname; set => contactname = value; }
        //public string Contactphone { get => contactphone; set => contactphone = value; }
        //public string Contactrelation { get => contactrelation; set => contactrelation = value; }
        //public float Height { get => height; set => height = value; }
        //public float Weight { get => weight; set => weight = value; }
        //public string Diseases { get => diseases; set => diseases = value; }
        //public int Idtexture { get => idtexture; set => idtexture = value; }
        //public int Numsensitivity { get => numsensitivity; set => numsensitivity = value; }
        //public string Classification { get => classification; set => classification = value; }
        //public string Image { get => image; set => image = value; }
        //public string Comments { get => comments; set => comments = value; }

        public Patient(string _id, string _firstname, string _lastname, string _dateofbirth, float _age, string _contactname, string _contactphone, string _contactrelation, float _height, float _weight, string _diseases, int _idtexture, int _numsensitivity, string _classification, string _image, string _comments)
        {
            Id = _id;
            FirstName = _firstname;
            LastName = _lastname;
            DateOfBirth = _dateofbirth;
            Age = _age;
            ContactName = _contactname;
            ContactPhone = _contactphone;
            ContactRelation = _contactrelation;
            Height = _height;
            Weight = _weight;
            Diseases = _diseases;
            IdTexture = _idtexture;
            NumSensitivity = _numsensitivity;
            Classification = _classification;
            Image = _image;
            Comments = _comments;


        }

        public Patient()
        {
        }

        public int insert()
        {

            DBservices dbs = new DBservices();
            int numAffected = dbs.insert(this);
            return numAffected;

        }

       

        //public List<Order> Read()
        //{

        //    DBservices db = new DBservices();

        //    return db.GetOrders();

        //}

    }
}