using Models.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ArticleTypeService : IArticleTypeService
    {
        private readonly List<ArticleType> data;

        public ArticleTypeService()
        {
            data = new List<ArticleType>();
            this.InitData();
        }

        public bool Creat(ArticleType data)
        {
            try
            {
                if (data.ID == Guid.Empty)
                {
                    data.ID = Guid.NewGuid();
                }
                this.data.Add(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(ArticleType data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ArticleType> GetAll()
        {
            ArticleType[] response = new ArticleType[data.Count];
            data.CopyTo(response);
            return response;
        }

        public void InitData()
        {
            data.AddRange(new ArticleType[]
            {
                new ArticleType {ID = Guid.NewGuid(), Name="Loại I"},
                new ArticleType {ID = Guid.NewGuid(), Name="Loại II"},
                new ArticleType {ID = Guid.NewGuid(), Name="Loại III"},
                new ArticleType {ID = Guid.NewGuid(), Name="Loại IV"},
                new ArticleType {ID = Guid.NewGuid(), Name="Loại V"}
            });
        }

        public bool Update(ArticleType data)
        {
            throw new NotImplementedException();
        }
    }
}
