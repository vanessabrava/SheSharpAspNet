using DevSturdy.Toolkit.Extension;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Business;

namespace Company.DataAccess.EntityFramework.Mapping
{
    public class UserMapConfig :EntityTypeConfiguration<User>
    {
        public UserMapConfig()
        {
            ToTable(MappingExtension<User>.GetTableName());

            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity)
                .HasColumnName(MappingExtension<User>.GetTableColumnId());

            Property(e => e.UserName)
                .HasColumnName(MappingExtension<User>.GetTableColumnText(e => e.UserName));
            Property(e => e.Password)
                .HasColumnName(MappingExtension<User>.GetTableColumnText(e => e.Password));


        }
    }
}
