namespace Practical03
{
    //Creating a class Laptop
    class Laptop
    {
        private string brand;
        private string model;
        //Get and set method for brand and model
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        //Printing Laptop details
        public void LaptopDetails()
        {
            Console.WriteLine("Brand :- " + Brand);
            Console.WriteLine("Model :- " + Model);
        }
        //This is private method
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }

    }
}
