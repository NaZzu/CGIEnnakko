using System.Collections.Generic;


public class BusinessIdSpecification : ISpecification<string>
{
    List<string> errorsDigit;
    List<string> errorsControl;
    public BusinessIdSpecification()
    {
        this.errorsDigit = new List<string>();
        this.errorsControl = new List<string>();

    }


    public IEnumerable<string> ReasonsForDissatisfaction
    {
        get
        {
            return errorsDigit;
        }
    }


    public IEnumerable<string> ControlMarkDissaatisfaction
    {
        get
        {
            return errorsControl;
        }
    }


    public bool IsControlOk(string entity)
    {
        Validator validator = new Validator(entity);
        this.errorsControl = validator.ValidateControl();
        if (errorsControl.Count > 0)
        {
            return false;
        }
        else
            return true;
    }


    public bool IsSatisfiedBy(string entity)
    {
        Validator validator = new Validator(entity);
        this.errorsDigit = validator.ValidateDigit();
        if (errorsDigit.Count > 0)
        {
            return false;
        }
        else
        return true;              
    }    
}
