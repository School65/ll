using Sate.Interfesis;
using Sate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sate.Mocks
{
    public class MProduct : IAllProduct
    {

        public IEnumerable<Product> Products
        {
            get
            {
                return new List<Product>
                {
                    new Product
                    {
                        name="Платье",
                        cipher="RT-76",
                        quantity=3,
                        img="https://i.pinimg.com/564x/5c/31/44/5c3144b1aaf1e2e8a583347a7cd13bfa.jpg",
                        url="https://www.google.com/search?q=%D0%BF%D0%BB%D0%B0%D1%82%D1%8C%D0%B5+%D0%BD%D0%B0+%D0%B2%D1%8B%D0%BF%D1%83%D1%81%D0%BA%D0%BD%D0%BE%D0%B9+%D0%B3%D1%80%D0%B0%D0%B4%D0%B8%D0%B5%D0%BD%D1%82&sxsrf=ALeKk03222On2ibThMMEydosnvXCpaO1FA:1589877512940&source=lnms&tbm=isch&sa=X&ved=2ahUKEwignZSjw7_pAhVImYsKHXyTAlsQ_AUoAXoECAwQAw&biw=958&bih=923"

                    },
                    new Product
                    {
                        name="Майка",
                        cipher="RE-16",
                        quantity=7,
                        img="https://i.pinimg.com/564x/8a/71/27/8a71277803c2503007ecb58c9ebca051.jpg",
                        url="https://www.google.com/search?q=%D0%BA%D1%80%D0%B0%D1%81%D0%B8%D0%B2%D1%8B%D0%B5+%D0%BC%D0%B0%D0%B9%D0%BA%D0%B8&sxsrf=ALeKk01xeyVyeLf0yakXJhrH7Y_0QQLRuA:1589877694385&source=lnms&tbm=isch&sa=X&ved=2ahUKEwjXwNb5w7_pAhXQtYsKHT1cAXkQ_AUoAXoECAwQAw&biw=958&bih=874"
                    },
                    new Product
                    {
                        name="Носки",
                        cipher="XT-6",
                        quantity=3,
                        img="https://i.pinimg.com/564x/88/9c/e7/889ce7a072f02dc78ba7a6d3cdc0dec8.jpg",
                        url="https://www.google.com/search?q=%D0%BD%D0%BE%D1%81%D0%BA%D0%B8+%D1%81+%D0%BF%D1%80%D0%B8%D0%BD%D1%82%D0%BE%D0%BC&tbm=isch&ved=2ahUKEwiPgMv7w7_pAhVFxioKHb0HCwkQ2-cCegQIABAA&oq=yjcrb+c+&gs_lcp=CgNpbWcQARgAMgQIABABMgQIABABMgQIABABMgQIABABMgQIABABMgQIABABMgQIABABMgQIABABMgQIABABMgQIABABOgIIADoGCAAQChABOgQIABBDOggIABAKEAEQGDoECAAQClCKxgFY_tABYNjdAWgAcAB4AIABZ4gB2gWSAQM3LjGYAQCgAQGqAQtnd3Mtd2l6LWltZw&sclient=img&ei=wpvDXo-XF8WMqwG9j6xI&bih=874&biw=958"
                    }
                };
            }
        }
    }
}