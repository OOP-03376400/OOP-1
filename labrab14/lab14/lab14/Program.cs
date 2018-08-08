using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Xml;

namespace lab14
{   
    [DataContract]
    [Serializable]
    public class Product
    {
        [DataMember]
        public string Product_Name = "";
        [DataMember]
        public int Price = 0;
        [DataMember]
        public string Produser = "";
        [DataMember]
        public int Amount = 0;

        public virtual void ShowInformation()
        {
            if (this.Product_Name == "Divan")
            {
                Console.WriteLine($"Price of {Product_Name} = {Price}");
                Console.WriteLine();
            }
        }
        public virtual void InputInformation()
        {

            if (this.Product_Name == "Divan")
            {
                Console.WriteLine($" Enter information about  {Product_Name}:");
                Console.Write("Produser: ");
                Produser = Console.ReadLine();
                Console.Write("Amount: ");
                Amount = int.Parse(Console.ReadLine());
            }
        }
        public virtual void FindingPrice()
        {
            if (Product_Name == "Divan")
            {
                Price = 23654 / Amount;
            }
        }
    }
    [Serializable]
   public class Divan : Product
    {
        public override string ToString()
        {
            string str = "";
            Console.WriteLine("Object type Divan:");
            Console.WriteLine($"Information about: {Product_Name} \n Produser={Produser} \n Amount={Amount} \n Price of Divan={Price}");
            return str;
        }
        public Divan()
        {
            Product_Name = "Divan";
        }
        public override void ShowInformation()
        {
            Console.WriteLine($"Price of {Product_Name} = {Price}");
            Console.WriteLine();

        }
        public override void InputInformation()
        {
            try
            {
                Console.WriteLine($"Enter information about  {Product_Name}:");
                Console.Write("Produser: ");
                Produser = Console.ReadLine();
                Console.Write("Amount: ");
                Amount = int.Parse(Console.ReadLine());
                if (Amount <= 0)
                {
                    throw new Exception("Wrong Amount");
                }
            }
            catch (Exception m)
            {
                {
                    Console.WriteLine("Error: " + m);
                }
            }

            finally
            {
                Console.WriteLine("Finally");
            }
        }
        public override void FindingPrice()
        {
            Price = 23654 / Amount;
            Console.WriteLine($"Price {Product_Name} found");
        }
    }
    class DifDiv
    {
        public string name { get; set; }
        public string Produser { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Divan();
            product.InputInformation();
            product.FindingPrice();
            product.ShowInformation();
            Console.WriteLine("Binary");
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("Divan.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, product);
                Console.WriteLine("Object serialized");
            }
            using (FileStream fs = new FileStream("Divan.dat", FileMode.OpenOrCreate))
            {
                Product newProduct = (Divan)binaryFormatter.Deserialize(fs);
                Console.WriteLine("Object deserialized");
                Console.WriteLine($"Product name:{newProduct.Product_Name}\nProduser:{newProduct.Produser}\nAmount:{newProduct.Amount}\nPrice of Divan:{newProduct.Price}");
            }
            Console.WriteLine();

            Console.WriteLine("Json");
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Divan));
            using (FileStream fs = new FileStream("Divan.json", FileMode.OpenOrCreate))
            {
                jsonSerializer.WriteObject(fs, product);
                Console.WriteLine("Object serialized");
            }
            using (FileStream fs = new FileStream("Divan.json", FileMode.OpenOrCreate))
            {
                Product newProduct = (Divan)jsonSerializer.ReadObject(fs);
                Console.WriteLine($"Product name:{newProduct.Product_Name}\nProduser:{newProduct.Produser}\nAmount:{newProduct.Amount}\nPrice of Divan:{newProduct.Price}");
            }
            Console.WriteLine();

            Console.WriteLine("Soap");
            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream fs = new FileStream("Divan.soap", FileMode.OpenOrCreate))
            {
                soapFormatter.Serialize(fs, product);
                Console.WriteLine("Object serialized");
            }
            using (FileStream fs = new FileStream("Divan.soap", FileMode.OpenOrCreate))
            {
                Product newProduct = (Divan)soapFormatter.Deserialize(fs);
                Console.WriteLine("Object deserialized");
                Console.WriteLine($"Product name:{newProduct.Product_Name}\nProduser:{newProduct.Produser}\nAmount:{newProduct.Amount}\nPrice of Divan:{newProduct.Price}");
            }
            Console.WriteLine();
            Console.WriteLine("XML");;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Divan));
            using (FileStream fs = new FileStream("Divan.xml", FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fs, product);
                Console.WriteLine("Object serialized");
            }
            using (FileStream fs = new FileStream("Divan.xml", FileMode.OpenOrCreate))
            {
                Product newProduct = (Divan)xmlSerializer.Deserialize(fs);
                Console.WriteLine("Object deserialized");
                Console.WriteLine($"Product name:{newProduct.Product_Name}\nProduser:{newProduct.Produser}\nAmount:{newProduct.Amount}\nPrice of Divan:{newProduct.Price}");
            }
            Console.WriteLine();

            Console.WriteLine("Array serialization");
            Product product2 = new Divan();
            product2.InputInformation();
            product2.FindingPrice();
            product2.ShowInformation();
            Product[] products = new Product[] { product, product2 };
            BinaryFormatter binaryFormatter2 = new BinaryFormatter();
            using (FileStream fs = new FileStream("Divan2.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fs, products);
                Console.WriteLine("Object serialized");
            }
            using (FileStream fs = new FileStream("Divan2.dat", FileMode.OpenOrCreate))
            {
                Product[] newProducts = (Product[])binaryFormatter2.Deserialize(fs);
                Console.WriteLine("Array object deserialized");
                foreach (Product p in newProducts)
                {
                    Console.WriteLine($"Product name:{p.Product_Name}\nProduser:{p.Produser}\nAmount:{p.Amount}\nPrice of Divan:{p.Price}");
                }
            }
            Console.WriteLine();


            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("Div.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList childnodes = xRoot.SelectNodes("*");
            foreach (XmlNode n in childnodes)
                Console.WriteLine(n.OuterXml);
            XmlNodeList childnodes2 = xRoot.SelectNodes("product");
            foreach (XmlNode n in childnodes2)
                Console.WriteLine(n.SelectSingleNode("@name").Value);
            Console.WriteLine("LINQ To XML");
            Console.WriteLine("Request 1");
            XDocument xdoc = XDocument.Load("Div.xml");
            var items = from xe in xdoc.Element("products").Elements("product")
                        where xe.Element("producer").Value == "ikea"
                        select new DifDiv
                        {
                            name = xe.Attribute("name").Value,
                            Produser=xe.Element("producer").Value,
                            Price = xe.Element("price").Value,
                            Amount = xe.Element("amount").Value
                        };

            foreach (var item in items)
                Console.WriteLine("{0} - {1} - {2}", item.name, item.Produser, item.Price, item.Amount);

            Console.WriteLine("Request 2");
            var items1 = from xe in xdoc.Element("products").Elements("product")
                         where xe.Element("amount").Value == "12"
                         select new DifDiv
                         {
                             name = xe.Attribute("name").Value,
                             Produser = xe.Element("producer").Value,
                             Price = xe.Element("price").Value,
                             Amount = xe.Element("amount").Value
                         };

            foreach (var item in items)
                Console.WriteLine("{0} - {1} - {2}", item.name, item.Produser, item.Price, item.Amount);

        }
    }
}
