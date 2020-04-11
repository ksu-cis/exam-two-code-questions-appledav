using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ExamTwoCodeQuestions.Data
{
    public class Cobbler : IOrderItem, INotifyPropertyChanged
    {


        /// <summary>
        /// The event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public FruitFilling fruit;
        /// <summary>
        /// The fruit used in the cobbler
        /// </summary>
        public FruitFilling Fruit
        {
            get
            {
                return fruit;
            }
            set
            {
                fruit = value;
                InvokePropertyChanged("Fruit");
            }
        }

        //{ get; set; } = true;
        public bool withIceCream = true;


        /// <summary>
        /// If the cobbler is served with ice cream
        /// </summary>
        public bool WithIceCream
        {
            get
            {
                return withIceCream;
            }
            set
            {
                withIceCream = value;
                InvokePropertyChanged("WithIceCream");
                InvokePropertyChanged("Price");
                InvokePropertyChanged("SpecialInstructions");
            }
        }

        /// <summary>
        /// Gets the price of the Cobbler
        /// </summary>
        public double Price
        {
            get
            {

                if (WithIceCream) return 5.32;
                else return 4.25;
            }
        }

        /// <summary>
        /// Gets any special instructions for preparing this dessert
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            { 
                if (WithIceCream) { return new List<string>(); }
                else { return new List<string>() { "Hold Ice Cream" }; }
                
            }
            
        }

        /// <summary>
        /// The method that invokes when a property is changed
        /// </summary>
        public void InvokePropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        

        
    }
}
