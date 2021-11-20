using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ICar myCar = new Maruti();
            CarDecorator OfferedPrice = new OfferPrice(myCar);
            OfferedPrice.ApplyDiscount(10000);
            OfferedPrice.GetFastagBank();
            OfferedPrice.make();
            OfferedPrice.Price();

            ICar myNewCar = new Hyundai();
            CarDecorator OfferedPrice2 = new OfferPrice(myNewCar);
            OfferedPrice2.ApplyDiscount(20000);
            OfferedPrice2.GetFastagBank();
            OfferedPrice2.Price();

    }
        class testDynamic : DynamicObject
        {

        }
    }

public interface ICar
{
    void make();
    int Price();
}
public sealed class Maruti : ICar
{
    public void make()
    {
        Console.Write("Maruti Swift");
    }

    public int Price()
    {
        return 500000;
    }
}

public sealed class Hyundai : ICar
{


    public void make()
    {
        Console.Write("Hyundai I20");
    }

    public int Price()
    {
        return 700000;
    }
}

public abstract class CarDecorator : ICar
{
    protected ICar _car;
    public CarDecorator(ICar car)
    {
        _car = car;
    }
    public void make() { _car.make(); }
    public int Price() { return _car.Price(); }

    public abstract int ApplyDiscount(int discount);
    public string GetFastagBank()
    {
        if (_car is Maruti) { return "Airtel Bank"; }
        else
        {
            return "PayTM Bank";
        }
    }
}

public class OfferPrice : CarDecorator
{
    public OfferPrice(ICar car) : base(car)
    {

    }
    public override int ApplyDiscount(int discount)
    {
        return _car.Price() - discount;
    }
}

}
