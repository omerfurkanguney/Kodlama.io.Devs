using Application.Features.Tecnologies.Dtos;
using Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Tecnologies.Models
{
    public class TechnologyListModel:BasePageableModel
    {
        public IList<TechnologyListDto> Items { get; set; }
    }
}
