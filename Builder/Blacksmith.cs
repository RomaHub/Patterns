using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{

    //Director: распорядитель - создает объект, используя объекты Builder
    class Blacksmith
    {
        //ItemBuilder itemBuilder;

        //public Blacksmith(ItemBuilder builder)
        //{
        //    itemBuilder = builder;
        //}

        //public void CreateCommonItem()
        //{
        //    itemBuilder.BuildPart1();
        //}

        public Item CreateCommonItem(ItemBuilder builder)
        {
            builder.BuildPart1();
            return builder.GetBuildedItem();
        }

        public Item CreateRareItem(ItemBuilder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            return builder.GetBuildedItem();
        }

        public Item CreateEpicItem(ItemBuilder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            builder.BuildPart3();
            return builder.GetBuildedItem();
        }

    }
}
