using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public interface IAutoFactory
    {

    }


    /// <summary>
    /// has order knife as in the base class
    /// </summary>
    public abstract class KnifeStore
    {
      //  KnifeFactory knifeFactory = null;
        //public KnifeStore(KnifeFactory knifeFactory)
        //{
        //    this.knifeFactory = knifeFactory;
        //}
        public  IKnife OrderKnife(string knifeName)
        {
            IKnife instance = CreateKnife(knifeName);
            instance.Polish();
            instance.Sharpen();
            instance.Package();
            return instance;
        }

     public   abstract IKnife CreateKnife(string knifeName);
    }

    /// <summary>
    ///  each subcalss has it's  own create knife imlementation
    /// </summary>
    public class BudgetKnifeStore: KnifeStore
    {
        public override IKnife CreateKnife(string knifeName)
        {
           // if else to create knife store
            // create to impelement the budgetknife store 
            throw new NotImplementedException();
        }
    }

    public class QualityknifeStore 
    { 



    }

  public  interface IKnife
    {
        void Sharpen();

        void Polish();
        void Package();
    }
  public class BudgetKnife : IKnife
  {
      public void Sharpen()
      { }
      public void Polish()
      { }
      public void Package()
      { }
  }
  public  class SteackKnife : IKnife
    {
        public void Sharpen()
        { }
        public void Polish()
        { }
        public void Package()
        { }
    }
    class ChefsKnife : IKnife
    {
        public void Sharpen()
        { }
        public void Polish()
        { }
        public void Package()
        { }
    }
}
