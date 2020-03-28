using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryObject
{
    class KnifeStore
    {
        KnifeFactory knifeFactory = null;
        public KnifeStore(KnifeFactory knifeFactory)
        {
            this.knifeFactory = knifeFactory;
        }
        public IKnife OrderKnife(string knifeName)
        {
            IKnife instance = knifeFactory.GetInstance(knifeName);
            instance.Polish();
            instance.Sharpen();
            instance.Package();
            return instance;
        }
    }


    class KnifeFactory
    {
        public IKnife GetInstance(string instanaceName)
        {
            // can use reflection insted
            IKnife instance = null;
            if (instanaceName == "steakKnife")
            {
                instance = new SteackKnife();
            }
            else if (instanaceName == "ChefsKnife")
            {
                instance = new ChefsKnife();
            }
            return instance;
        }
    }
    interface IKnife
    {
         void Sharpen();

         void Polish();
        void Package();
    }

    class SteackKnife : IKnife
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
