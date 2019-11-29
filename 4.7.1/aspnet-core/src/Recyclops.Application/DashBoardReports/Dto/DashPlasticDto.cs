﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recyclops.DashBoardReports.Dto
{
    public class DashPlasticDto
    {
        public DashPlasticDto(List<Domains.Plastic.Plastic> domList)
        {
            var monthAgo = DateTime.Today.AddMonths(-1);


            PlasticCount = domList.Count();
            NewPlasticCount = domList.Count(x => x.CreationTime >= monthAgo);


        }

        public int PlasticCount { get; set; }
        public int NewPlasticCount { get; set; }
    }
}