using System.Collections.Generic;





public class Validator
{
    List<string> errorsDigit;
    List<string> errorsControl;
    string entity;


    public Validator(string entity)
    {
        this.entity = entity;
        this.errorsDigit = new List<string>();
        this.errorsControl = new List<string>();
    }

   
    public List<string> ValidateDigit()
    {
        DigitNumbersOnly();
        DigitLength();

        return this.errorsDigit;
    }


    public List<string> ValidateControl()
    {
        ControlNumberOnly();
        ControlLength();

        return this.errorsControl;
    }


    public void DigitLength()
    {
        if (entity.Length > 7)
        {
            errorsDigit.Add("Your BusinessID is too long, a typo or an imaginary business?");
        }
        else if (entity.Length < 7)
        {
            errorsDigit.Add("Your BusinessID is too short, did you forget a digit?");
        }
    }


    public void DigitNumbersOnly()
    {
        int digits;
        if (!int.TryParse(entity, out digits))
        {
            errorsDigit.Add("Did you know, that BusinessID can only contain numbers? Now you do.");
        }
    }


    public void ControlLength()
    {
        if (entity.Length != 1)
        {
            errorsControl.Add("Control mark can only contain 1 number.");
        }
    }


    public void ControlNumberOnly()
    {
        int _digits;
        if (!int.TryParse(entity, out _digits))
        {
            errorsControl.Add("Unless you have an imaginary business, control mark has to be a number");
        }
    }
}



