using HR_CMS.Data;
using HR_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Services
{
    public class DeptService
    {
        public bool CreateDept(DeptCreate model)
        {
            var entity = new Dept()
            {
                DeptName = model.DeptName,
                PersonnelCount = model.PersonnelCount
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.DeptDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<DeptListItem> GetDepts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .DeptDbSet
                    .Select(
                        e =>
                            new DeptListItem
                            {
                                DeptId = e.DeptId,
                                DeptName = e.DeptName,
                                PersonnelCount = e.PersonnelCount
                            }
                    );
                return query.ToArray();
            }
        }
        public DeptDetail GetDeptById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .DeptDbSet
                        .Single(e => e.DeptId == id);
                return
                    new DeptDetail
                    {
                        DeptId = entity.DeptId,
                        DeptName = entity.DeptName,
                        PersonnelCount = entity.PersonnelCount,

                    };
            }
        }
        public bool UpdateDept(DeptDetail model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .DeptDbSet
                    .Single(e => e.DeptId == model.DeptId);
                entity.DeptName = model.DeptName;
                entity.PersonnelCount = model.PersonnelCount;
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
