using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using WorkManSys.Entity.Models;

#nullable disable

namespace WorkManSys.Dal.Concrete.Entityframework.Context
{
    public partial class WorkManagementSystemContext : DbContext
    {
        //public WorkManagementSystemContext()
        //{
        //}
        //IConfiguration configuration;
        //public WorkManagementSystemContext(IConfiguration configuration)
        //{
        //    this.configuration = configuration;
        //}
        //public WorkManagementSystemContext(DbContextOptions<WorkManagementSystemContext> options)
        //    : base(options)
        //{
        //}

        public virtual DbSet<Departmant> Departmants { get; set; }
        public virtual DbSet<Personal> Personals { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-G9IER4GV\\SQLEXPRESS2017;Database=WorkManagementSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Departmant>(entity =>
            {
                entity.HasKey(e => e.DepId);

                entity.ToTable("Departmant");

                entity.Property(e => e.DepId).HasColumnName("Dep_ID");

                entity.Property(e => e.DepName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Dep_Name");
            });

            modelBuilder.Entity<Personal>(entity =>
            {
                entity.HasKey(e => e.PerId);

                entity.ToTable("Personal");

                entity.Property(e => e.PerId).HasColumnName("Per_ID");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_ID");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PerLastname)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Per_Lastname");

                entity.Property(e => e.PerName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Per_Name");

                entity.Property(e => e.Phone).HasMaxLength(24);

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personal_Departmant");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Personals)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personal_Role");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.ReqId)
                    .HasName("PK_Request2");

                entity.ToTable("Request");

                entity.Property(e => e.ReqId).HasColumnName("Req_ID");

                entity.Property(e => e.ReqCreationdate)
                    .HasColumnType("datetime")
                    .HasColumnName("Req_Creationdate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReqDepartmantid).HasColumnName("Req_Departmantid");

                entity.Property(e => e.ReqDetails)
                    .IsRequired()
                    .HasColumnName("Req_Details");

                entity.Property(e => e.ReqFinishdate)
                    .HasColumnType("datetime")
                    .HasColumnName("Req_Finishdate");

                entity.Property(e => e.ReqHeader)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Req_Header");

                entity.Property(e => e.ReqOwnerid).HasColumnName("Req_Ownerid");

                entity.Property(e => e.ReqStartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("Req_Startdate");

                entity.Property(e => e.ReqStatusid).HasColumnName("Req_Statusid");

                entity.Property(e => e.ReqSubjectid).HasColumnName("Req_Subjectid");

                entity.HasOne(d => d.ReqDepartmant)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ReqDepartmantid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_Departmant");

                entity.HasOne(d => d.ReqOwner)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ReqOwnerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_Personal");

                entity.HasOne(d => d.ReqStatus)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ReqStatusid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_Status");

                entity.HasOne(d => d.ReqSubject)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ReqSubjectid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Request_Subject");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("Role_ID");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Role_Name");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("Status");

                entity.Property(e => e.StatusId)
                    .ValueGeneratedNever()
                    .HasColumnName("Status_ID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("Status_Name");
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.ToTable("Subject");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_ID");

                entity.Property(e => e.DeparmentId).HasColumnName("Deparment_ID");

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("Subject_Name");

                entity.HasOne(d => d.Deparment)
                    .WithMany(p => p.Subjects)
                    .HasForeignKey(d => d.DeparmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subject_Departmant");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
