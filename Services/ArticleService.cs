using Models;
using Models.Entity;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ArticleService : IArticleService
    {
        private List<Article> data { get; set; }
        private readonly IArticleTypeService context;

        public ArticleService(IArticleTypeService context)
        {
            this.context = context;
            data = new List<Article>();
            InitData();
        }

        public bool Creat(Article data)
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

        public bool Delete(Article data)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAll()
        {
            Article[] response = new Article[data.Count];
            data.CopyTo(response);
            return response;
        }

        public void InitData()
        {
            int Count = 1;
            foreach (var item in context.GetAll())
            {
                data.AddRange(new Article[]
                {
                    new Article { ID = Guid.NewGuid(), Content="Lorem", Title=$"Bài tiếp {Count++}", Type=item, UpTime=DateTime.Now},
                    new Article { ID = Guid.NewGuid(), Content="Lorem", Title=$"Bài tiếp {Count++}", Type=item, UpTime=DateTime.Now},
                    new Article { ID = Guid.NewGuid(), Content="Lorem", Title=$"Bài tiếp {Count++}", Type=item, UpTime=DateTime.Now},
                    new Article { ID = Guid.NewGuid(), Content="Lorem", Title=$"Bài tiếp {Count++}", Type=item, UpTime=DateTime.Now},
                    new Article { ID = Guid.NewGuid(), Content="Lorem", Title=$"Bài tiếp {Count++}", Type=item, UpTime=DateTime.Now},
                });
            }
        }

        public bool Update(Article data)
        {
            throw new NotImplementedException();
        }
    }
}
