using AS_SRS_LMS.Models;

namespace AS_SRS_LMS.Interface
{
    public interface ISub
    {
        List<Subject> GetAllSub();
        void AddSub(SubjectRequest request);
        void RemoveSub(string id);
        void UpdateSub(string id, SubjectRequest request);
        Subject DetailSub(string id);
        


    }
    public class SubjectManager : ISub
    {
        private readonly DataContext _dataContext;
        public SubjectManager(DataContext context)
        {
            _dataContext = context;
        }
        public void AddSub(SubjectRequest request)
        {
            var sub = new Subject
            {
                SubjectName = request.SubjectName,
                Period = request.Period,         
            };
            _dataContext.Subject.Add(sub);
            _dataContext.SaveChanges();
        }

        public Subject DetailSub(string id)
        {
            var sub = _dataContext.Subject.Find(id);
            return sub;
        }

        public List<Subject> GetAllSub()
        {
            return _dataContext.Subject.ToList();
        }

        public void RemoveSub(string id)
        {
            var sub = _dataContext.Subject.Find(id);
            _dataContext.Subject.Remove(sub);
            _dataContext.SaveChanges();
        }

        public void UpdateSub(string id, SubjectRequest request)
        {
            var sub = _dataContext.Subject.Find(id);
            var sub1 = new Subject
            {
                SubjectName = request.SubjectName,
                Period = request.Period,
            };
            _dataContext.Subject.Update(sub);
            _dataContext.SaveChanges();
        }
    }
}
