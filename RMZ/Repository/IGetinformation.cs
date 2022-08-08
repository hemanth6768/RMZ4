using RMZ.MODEL;
using System.Linq;

namespace RMZ.Repository
{
    public interface IGetinformation
    {
        public IQueryable getzone(string facility, string data, string id);

        public IQueryable getbuilding(string facility, string data);

        public IQueryable getfacility(string facility, string data);
    }
}
