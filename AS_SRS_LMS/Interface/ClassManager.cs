using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Interface
{
    public interface IClass
    {
        List<Class> GetAllClass();
        void AddClass(ClassRequest request);
        void RemoveClass(string id);
        void UpdateClass(string id, ClassRequest request);
        Class DetailClass(string id);



    }
    public class ClassManager : IClass
    {
        private readonly DataContext _dataContext;
        public ClassManager(DataContext context)
        {
            _dataContext = context;
        }
        public void AddClass(ClassRequest request)
        {
            var cla = new Class
            {
                NameClass = request.ClassName,
                Amount = request.Amount,
            };
            _dataContext.Class.Add(cla);
            _dataContext.SaveChanges();
        }

        public Class DetailClass(string id)
        {
            var cla = _dataContext.Class.Find(id);
            return cla;
        }

        public List<Class> GetAllClass()
        {
            return _dataContext.Class.ToList();
        }

        public void RemoveClass(string id)
        {
            var cla = _dataContext.Class.Find(id);
            _dataContext.Class.Remove(cla);
            _dataContext.SaveChanges();
        }

        public void UpdateClass(string id, ClassRequest request)
        {
            var cla = _dataContext.Class.Find(id);
            Class cla1 = new Class
            {
                NameClass = request.ClassName,
                
            };
            _dataContext.Class.Update(cla);
            _dataContext.SaveChanges();
        }
    }
}
