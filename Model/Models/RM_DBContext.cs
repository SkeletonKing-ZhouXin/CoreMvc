using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Model.Models
{
    public partial class RM_DBContext : DbContext
    {
        public RM_DBContext()
        {
        }

        public RM_DBContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-3FJ6UH8\\MSSQLSERVER2014;database=RM_DB;Trusted_Connection=True;");
        }

        public virtual DbSet<BaseAppendProperty> BaseAppendProperty { get; set; }
        public virtual DbSet<BaseAppendPropertyInstance> BaseAppendPropertyInstance { get; set; }
        public virtual DbSet<BaseButton> BaseButton { get; set; }
        public virtual DbSet<BaseOASetup> BaseOASetup { get; set; }
        public virtual DbSet<BaseOrganization> BaseOrganization { get; set; }
        public virtual DbSet<BaseRecyclebin> BaseRecyclebin { get; set; }
        public virtual DbSet<BaseRoleRight> BaseRoleRight { get; set; }
        public virtual DbSet<BaseRoles> BaseRoles { get; set; }
        public virtual DbSet<BaseStaffOrganize> BaseStaffOrganize { get; set; }
        public virtual DbSet<BaseSysMenu> BaseSysMenu { get; set; }
        public virtual DbSet<BaseUserGroup> BaseUserGroup { get; set; }
        public virtual DbSet<BaseUserGroupRight> BaseUserGroupRight { get; set; }
        public virtual DbSet<BaseUserInfo> BaseUserInfo { get; set; }
        public virtual DbSet<BaseUserInfoUserGroup> BaseUserInfoUserGroup { get; set; }
        public virtual DbSet<BaseUserRight> BaseUserRight { get; set; }
        public virtual DbSet<BaseUserRole> BaseUserRole { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseAppendProperty>(entity =>
            {
                entity.HasKey(e => e.PropertyId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_AppendProperty");

                entity.Property(e => e.PropertyId)
                    .HasColumnName("Property_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteMark)
                    .HasColumnType("ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDate).HasColumnType("Date");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyColspan)
                    .HasColumnName("Property_Colspan")
                    .HasColumnType("ID");

                entity.Property(e => e.PropertyControlDataSource)
                    .HasColumnName("Property_Control_DataSource")
                    .HasColumnType("Name(Max)")
                    .IsUnicode(false);

                entity.Property(e => e.PropertyControlId)
                    .HasColumnName("Property_Control_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyControlLength)
                    .HasColumnName("Property_Control_Length")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyControlMaxlength)
                    .HasColumnName("Property_Control_Maxlength")
                    .HasColumnType("ID");

                entity.Property(e => e.PropertyControlStyle)
                    .HasColumnName("Property_Control_Style")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyControlType)
                    .HasColumnName("Property_Control_Type")
                    .HasColumnType("ID");

                entity.Property(e => e.PropertyControlValidator)
                    .HasColumnName("Property_Control_Validator")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyEvent)
                    .HasColumnName("Property_Event")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyFunction)
                    .HasColumnName("Property_Function")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyFunctionUrl)
                    .HasColumnName("Property_FunctionUrl")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyName)
                    .HasColumnName("Property_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode).HasColumnType("ID");
            });

            modelBuilder.Entity<BaseAppendPropertyInstance>(entity =>
            {
                entity.HasKey(e => e.PropertyInstanceId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_AppendPropertyInstance");

                entity.Property(e => e.PropertyInstanceId)
                    .HasColumnName("PropertyInstance_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.PropertyControlId)
                    .HasColumnName("Property_Control_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyInstanceKey)
                    .HasColumnName("PropertyInstance_Key")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyInstanceValue)
                    .HasColumnName("PropertyInstance_Value")
                    .HasColumnType("Name(Max)")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaseButton>(entity =>
            {
                entity.HasKey(e => e.ButtonId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_Button");

                entity.Property(e => e.ButtonId)
                    .HasColumnName("Button_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ButtonCode)
                    .HasColumnName("Button_Code")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonImg)
                    .HasColumnName("Button_Img")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonName)
                    .HasColumnName("Button_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonRemak)
                    .HasColumnName("Button_Remak")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonTitle)
                    .HasColumnName("Button_Title")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ButtonType)
                    .HasColumnName("Button_Type")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteMark)
                    .HasColumnType("ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDate).HasColumnType("Date");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode).HasColumnType("ID");
            });

            modelBuilder.Entity<BaseOASetup>(entity =>
            {
                entity.HasKey(e => e.SetupId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_O_A_Setup");

                entity.Property(e => e.SetupId)
                    .HasColumnName("Setup_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NavigateUrl)
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SetupImg)
                    .HasColumnName("Setup_Img")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetupIname)
                    .HasColumnName("Setup_IName")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SetupRemak)
                    .HasColumnName("Setup_Remak")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode).HasColumnType("ID");

                entity.Property(e => e.Target)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BaseOASetup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Base_O_A_Setup_Base_UserInfo");
            });

            modelBuilder.Entity<BaseOrganization>(entity =>
            {
                entity.HasKey(e => e.OrganizationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_Organization");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("Organization_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteMark)
                    .HasColumnType("ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDate).HasColumnType("Date");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationAddress)
                    .HasColumnName("Organization_Address")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationAssistantManager)
                    .HasColumnName("Organization_AssistantManager")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationCode)
                    .HasColumnName("Organization_Code")
                    .HasColumnType("Name(20)")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationFax)
                    .HasColumnName("Organization_Fax")
                    .HasColumnType("Name(20)")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationInnerPhone)
                    .HasColumnName("Organization_InnerPhone")
                    .HasColumnType("Name(20)")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationManager)
                    .HasColumnName("Organization_Manager")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationName)
                    .HasColumnName("Organization_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationOuterPhone)
                    .HasColumnName("Organization_OuterPhone")
                    .HasColumnType("Name(20)")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationRemark)
                    .HasColumnName("Organization_Remark")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationZipcode)
                    .HasColumnName("Organization_Zipcode")
                    .HasColumnType("Name(20)")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode).HasColumnType("ID");
            });

            modelBuilder.Entity<BaseRecyclebin>(entity =>
            {
                entity.HasKey(e => e.RecyclebinId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_Recyclebin");

                entity.Property(e => e.RecyclebinId)
                    .HasColumnName("Recyclebin_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecyclebinDatabase)
                    .HasColumnName("Recyclebin_Database")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecyclebinEventField)
                    .HasColumnName("Recyclebin_EventField")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecyclebinFieldKey)
                    .HasColumnName("Recyclebin_FieldKey")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecyclebinName)
                    .HasColumnName("Recyclebin_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecyclebinRemark)
                    .HasColumnName("Recyclebin_Remark")
                    .HasColumnType("Name(Max)")
                    .IsUnicode(false);

                entity.Property(e => e.RecyclebinTable)
                    .HasColumnName("Recyclebin_Table")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaseRoleRight>(entity =>
            {
                entity.HasKey(e => e.RoleRightId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_RoleRight");

                entity.Property(e => e.RoleRightId)
                    .HasColumnName("RoleRight_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_Id")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RolesId)
                    .HasColumnName("Roles_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.BaseRoleRight)
                    .HasForeignKey(d => d.RolesId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Base_RoleRight_Base_Roles");
            });

            modelBuilder.Entity<BaseRoles>(entity =>
            {
                entity.HasKey(e => e.RolesId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_Roles");

                entity.Property(e => e.RolesId)
                    .HasColumnName("Roles_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowDelete).HasColumnType("ID");

                entity.Property(e => e.AllowEdit).HasColumnType("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteMark)
                    .HasColumnType("ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDate).HasColumnType("Date");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleRestriction)
                    .HasColumnName("Role_Restriction")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RolesName)
                    .HasColumnName("Roles_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RolesRemark)
                    .HasColumnName("Roles_Remark")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode).HasColumnType("ID");
            });

            modelBuilder.Entity<BaseStaffOrganize>(entity =>
            {
                entity.HasKey(e => e.StaffOrganizeId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_StaffOrganize");

                entity.Property(e => e.StaffOrganizeId)
                    .HasColumnName("StaffOrganize_Id")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("Organization_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Organization)
                    .WithMany(p => p.BaseStaffOrganize)
                    .HasForeignKey(d => d.OrganizationId)
                    .HasConstraintName("FK_Base_StaffOrganize_Base_Organization");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BaseStaffOrganize)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Base_StaffOrganize_Base_UserInfo");
            });

            modelBuilder.Entity<BaseSysMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_SysMenu");

                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_Id")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowDelete).HasColumnType("ID");

                entity.Property(e => e.AllowEdit).HasColumnType("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteMark)
                    .HasColumnType("ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MenuImg)
                    .HasColumnName("Menu_Img")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName)
                    .HasColumnName("Menu_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuTitle)
                    .HasColumnName("Menu_Title")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuType)
                    .HasColumnName("Menu_Type")
                    .HasColumnType("ID");

                entity.Property(e => e.ModifyDate).HasColumnType("Date");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NavigateUrl)
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode).HasColumnType("ID");

                entity.Property(e => e.Target)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaseUserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroupId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_UserGroup");

                entity.Property(e => e.UserGroupId)
                    .HasColumnName("UserGroup_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowDelete).HasColumnType("ID");

                entity.Property(e => e.AllowEdit).HasColumnType("ID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteMark)
                    .HasColumnType("ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ModifyDate).HasColumnType("Date");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SortCode).HasColumnType("ID");

                entity.Property(e => e.UserGroupCode)
                    .HasColumnName("UserGroup_Code")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupName)
                    .HasColumnName("UserGroup_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupRemark)
                    .HasColumnName("UserGroup_Remark")
                    .HasColumnType("Name(200)")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BaseUserGroupRight>(entity =>
            {
                entity.HasKey(e => e.UserGroupRightId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_UserGroupRight");

                entity.Property(e => e.UserGroupRightId)
                    .HasColumnName("UserGroupRight_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_Id")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupId)
                    .HasColumnName("UserGroup_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.BaseUserGroupRight)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Base_UserGroupRight_Base_UserGroup");
            });

            modelBuilder.Entity<BaseUserInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_UserInfo");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AnswerQuestion)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeleteMark)
                    .HasColumnType("ID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Email)
                    .HasColumnType("Name(20)")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate).HasColumnType("Date");

                entity.Property(e => e.ModifyUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Question)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Theme)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserAccount)
                    .HasColumnName("User_Account")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCode)
                    .HasColumnName("User_Code")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("User_Name")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasColumnName("User_Pwd")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserRemark)
                    .HasColumnName("User_Remark")
                    .HasColumnType("Name(Max)")
                    .IsUnicode(false);

                entity.Property(e => e.UserSex)
                    .HasColumnName("User_Sex")
                    .HasColumnType("ID");
            });

            modelBuilder.Entity<BaseUserInfoUserGroup>(entity =>
            {
                entity.HasKey(e => e.UserInfoUserGroupId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_UserInfoUserGroup");

                entity.Property(e => e.UserInfoUserGroupId)
                    .HasColumnName("UserInfoUserGroup_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserGroupId)
                    .HasColumnName("UserGroup_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.BaseUserInfoUserGroup)
                    .HasForeignKey(d => d.UserGroupId)
                    .HasConstraintName("FK_Base_UserInfoUserGroup_Base_UserGroup");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BaseUserInfoUserGroup)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Base_UserInfoUserGroup_Base_UserInfo");
            });

            modelBuilder.Entity<BaseUserRight>(entity =>
            {
                entity.HasKey(e => e.UserRightId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_UserRight");

                entity.Property(e => e.UserRightId)
                    .HasColumnName("UserRight_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MenuId)
                    .HasColumnName("Menu_Id")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BaseUserRight)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Base_UserRight_Base_UserInfo");
            });

            modelBuilder.Entity<BaseUserRole>(entity =>
            {
                entity.HasKey(e => e.UserRoleId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("Base_UserRole");

                entity.Property(e => e.UserRoleId)
                    .HasColumnName("UserRole_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreateDate)
                    .HasColumnType("Date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreateUserId)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreateUserName)
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RolesId)
                    .HasColumnName("Roles_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasColumnType("Name(50)")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Roles)
                    .WithMany(p => p.BaseUserRole)
                    .HasForeignKey(d => d.RolesId)
                    .HasConstraintName("FK_Base_UserRole_Base_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.BaseUserRole)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Base_UserRole_Base_UserInfo");
            });
        }
    }
}
