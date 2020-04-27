using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace XmlForm
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void MainApp_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




      
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = XMLjobs.GetCars();
        }

       

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                // фамилия владельца, код марки автомобиля, марка автомобиля, требуемая марка бензина, мощность двигателя, объем бака, остаток бензина, объем масла
                string      mark_code
                            , owner
                            , mark
                            , fuel;

                float        power
                            ,volume
                            ,fuel_left
                            ,oil;
               

                mark_code = textBoxMarkcode.Text;
                owner = textBoxOwner.Text;
                mark = textBoxMarked.Text;
                fuel = textBoxFuel.Text;

                power = float.Parse(textBoxPower.Text);
                volume = float.Parse(textBoxVolume.Text);
                fuel_left = float.Parse(textBoxFuelLeft.Text);
                oil = float.Parse(textBoxOil.Text);

                    if (mark_code == "" || owner == "" || mark == "" || fuel == "" || power < 0 || volume < 0 || fuel_left < 0 || oil < 0)
                    {
                        MessageBox.Show("Null or negative values are not allowed! Check you values!");
                    }
                    else
                    {
                    XMLjobs.CarAdd(mark_code, owner, mark, fuel, textBoxPower.Text, textBoxVolume.Text, textBoxFuelLeft.Text, textBoxOil.Text);
                    }
                
                textBox1.Text = XMLjobs.GetCars();
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong data input! Check float values!");
            }
        }

        private void buttonremove_Click(object sender, EventArgs e)
        {
          
                if (textBoxRemove.Text!="")
                { 
                string mark_code = textBoxRemove.Text;
                    XMLjobs.CarRemove(mark_code);
                }
                else MessageBox.Show("Error! Mark code is not correct!");

            textBox1.Text = XMLjobs.GetCars();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string val;
            ToolStripMenuItem MenuButton = (ToolStripMenuItem)sender;
            Search search = new Search();
            if (search.ShowDialog() == DialogResult.OK)
            {
            
                    if (MenuButton.Text == "mark") { textBox1.Text = XMLjobs.SearchCarMark(search.val); }
                    else if (MenuButton.Text == "owner") { textBox1.Text = XMLjobs.SearchCarOwner(search.val); }
                    else if(MenuButton.Text == "fuel") { textBox1.Text = XMLjobs.SearchCarFuel(search.val); }
                    else if(MenuButton.Text == "power") { textBox1.Text = XMLjobs.SearchCarPower(search.val); }

                }
            }
        }
    }

    public class XMLjobs
    {
        class Car
        {
            public string mark_code { get; set; }
            public string owner { get; set; }
            public string mark { get; set; }
            public string fuel { get; set; }
            public float power { get; set; }
            public float volume { get; set; }
            public float fuel_left { get; set; }
            public float oil { get; set; }
        }

        public static void CarRemove(string mark_code)
        {
            XDocument xdoc = XDocument.Load("cars.xml");
            XElement root = xdoc.Element("cars");
            foreach (XElement temp in root.Elements("car").ToList())
                if (temp.Attribute("mark_code").Value == mark_code)
                {
                    temp.Remove();
                }
            xdoc.Save("cars.xml");
        }
     
        public static void CarAdd(string mark_code
                            , string owner
                            , string mark
                            , string fuel
                            , string power
                            , string volume
                            , string fuel_left
                            , string oil)
        {
            XDocument xdoc = XDocument.Load("cars.xml");
            XElement root = xdoc.Element("cars");
            root.Add(new XElement("car",
                             new XAttribute("mark_code", mark_code),
                             new XElement("owner", owner),
                             new XElement("mark", mark),
                             new XElement("fuel", fuel),
                             new XElement("power", power),
                             new XElement("volume", volume),
                             new XElement("fuel_left", fuel_left),
                             new XElement("oil", oil)
                             ));
            xdoc.Save("Cars.xml");
        }
       
        public static string GetCars()
        {
            string output = "";
            XDocument xdoc = XDocument.Load("cars.xml");
            var items = from xe in xdoc.Element("cars").Elements("car")
                        select new Car
                        {
                            mark_code = xe.Attribute("mark_code").Value,
                            owner = xe.Element("owner").Value,
                            mark = xe.Element("mark").Value,
                            fuel = xe.Element("fuel").Value,
                            power = float.Parse(xe.Element("power").Value),
                            volume = float.Parse(xe.Element("volume").Value),
                            fuel_left = float.Parse(xe.Element("fuel_left").Value),
                            oil = float.Parse(xe.Element("oil").Value)
                        };

            foreach (var item in items)
            {
                output = output + $"Mark_code: {item.mark_code}\r\n owner: {item.owner}\r\n mark: {item.mark}\r\n fuel: {item.fuel}\r\n power: {item.power}\r\n volume: {item.volume}\r\n fuel_left: {item.fuel_left}\r\n oil: {item.oil}\r\n\r\n " ;
            }
            return output;
        }
        public static string SearchCarMark(string mark)
        {
            string output = "";
            XDocument xdoc = XDocument.Load("cars.xml");
            var items = from xe in xdoc.Element("cars").Elements("car")
                        where xe.Element("mark").Value == mark
                        select new Car
                        {
                            mark_code = xe.Attribute("mark_code").Value,
                            owner = xe.Element("owner").Value,
                            mark = xe.Element("mark").Value,
                            fuel = xe.Element("fuel").Value,
                            power = float.Parse(xe.Element("power").Value),
                            volume = float.Parse(xe.Element("volume").Value),
                            fuel_left = float.Parse(xe.Element("fuel_left").Value),
                            oil = float.Parse(xe.Element("oil").Value)
                        };

            foreach (var item in items)
            {
                output = output + $"Mark_code: {item.mark_code}\r\n owner: {item.owner}\r\n mark: {item.mark}\r\n fuel: {item.fuel}\r\n power: {item.power}\r\n volume: {item.volume}\r\n fuel_left: {item.fuel_left}\r\n oil: {item.oil}\r\n\r\n ";
            }
            return output;
        }

        public static string SearchCarPower(string power)
        {
            string output = "";
            XDocument xdoc = XDocument.Load("cars.xml");
            var items = from xe in xdoc.Element("cars").Elements("car")
                        where xe.Element("power").Value == power
                        select new Car
                        {
                            mark_code = xe.Attribute("mark_code").Value,
                            owner = xe.Element("owner").Value,
                            mark = xe.Element("mark").Value,
                            fuel = xe.Element("fuel").Value,
                            power = float.Parse(xe.Element("power").Value),
                            volume = float.Parse(xe.Element("volume").Value),
                            fuel_left = float.Parse(xe.Element("fuel_left").Value),
                            oil = float.Parse(xe.Element("oil").Value)
                        };

            foreach (var item in items)
            {
                output = output + $"Mark_code: {item.mark_code}\r\n owner: {item.owner}\r\n mark: {item.mark}\r\n fuel: {item.fuel}\r\n power: {item.power}\r\n volume: {item.volume}\r\n fuel_left: {item.fuel_left}\r\n oil: {item.oil}\r\n\r\n ";
            }
            return output;
        }

        public static string SearchCarFuel(string fuel)
        {
            string output = "";
            XDocument xdoc = XDocument.Load("cars.xml");
            var items = from xe in xdoc.Element("cars").Elements("car")
                        where xe.Element("fuel").Value == fuel
                        select new Car
                        {
                            mark_code = xe.Attribute("mark_code").Value,
                            owner = xe.Element("owner").Value,
                            mark = xe.Element("mark").Value,
                            fuel = xe.Element("fuel").Value,
                            power = float.Parse(xe.Element("power").Value),
                            volume = float.Parse(xe.Element("volume").Value),
                            fuel_left = float.Parse(xe.Element("fuel_left").Value),
                            oil = float.Parse(xe.Element("oil").Value)
                        };

            foreach (var item in items)
            {
                output = output + $"Mark_code: {item.mark_code}\r\n owner: {item.owner}\r\n mark: {item.mark}\r\n fuel: {item.fuel}\r\n power: {item.power}\r\n volume: {item.volume}\r\n fuel_left: {item.fuel_left}\r\n oil: {item.oil}\r\n\r\n ";
            }
            return output;
        }
        public static string SearchCarOwner(string owner)
        {
            string output = "";
            XDocument xdoc = XDocument.Load("cars.xml");
            var items = from xe in xdoc.Element("cars").Elements("car")
                        where xe.Element("owner").Value == owner
                        select new Car
                        {
                            mark_code = xe.Attribute("mark_code").Value,
                            owner = xe.Element("owner").Value,
                            mark = xe.Element("mark").Value,
                            fuel = xe.Element("fuel").Value,
                            power = float.Parse(xe.Element("power").Value),
                            volume = float.Parse(xe.Element("volume").Value),
                            fuel_left = float.Parse(xe.Element("fuel_left").Value),
                            oil = float.Parse(xe.Element("oil").Value)
                        };

            foreach (var item in items)
            {
                output = output + $"Mark_code: {item.mark_code}\r\n owner: {item.owner}\r\n mark: {item.mark}\r\n fuel: {item.fuel}\r\n power: {item.power}\r\n volume: {item.volume}\r\n fuel_left: {item.fuel_left}\r\n oil: {item.oil}\r\n\r\n ";
            }
            return output;
        }
       
      
        public static string TestCars(string mark_code
                                        , string owner
                                        , string mark
                                        , string fuel
                                        , float power
                                        , float volume
                                        , float fuel_left
                                        , float oil)
        {
            string output = "" ;
            output = output + $"Mark_code: {mark_code}\r\n owner: {owner}\r\n mark: {mark}\r\n fuel: {fuel}\r\n power: {power}\r\n volume: {volume}\r\n fuel_left: {fuel_left}\r\n oil: {oil}\r\n\r\n ";
            return output;
        }
        public static bool CheckFloatValues(string str)
        {
            float temp;

            try
            {
                temp = float.Parse(str);
            }

            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public static bool CheckValues(string mark_code
                                        , string owner
                                        , string mark
                                        , string fuel
                                        , float power
                                        , float volume
                                        , float fuel_left
                                        , float oil)
        {
            
            if (mark_code == "" || owner == "" || mark == "" || fuel == "" || power < 0 || volume < 0 || fuel_left < 0 || oil < 0)
            {
                return false;
            }
            return true;
        }

    }
 



