// <auto-generated />
using Labb2.Net21LinQKimWiklund.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb2.Net21LinQKimWiklund.Migrations
{
    [DbContext(typeof(LabbDBContext))]
    partial class LabbDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            CourseId = 1,
                            CourseName = "Math"
                        },
                        new
                        {
                            CourseId = 2,
                            CourseName = "Geography"
                        },
                        new
                        {
                            CourseId = 3,
                            CourseName = "English"
                        },
                        new
                        {
                            CourseId = 4,
                            CourseName = "Biology"
                        });
                });

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.SchoolClass", b =>
                {
                    b.Property<int>("SchoolClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SchoolClassName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SchoolClassId");

                    b.ToTable("SchoolClasses");

                    b.HasData(
                        new
                        {
                            SchoolClassId = 1,
                            SchoolClassName = "1A"
                        },
                        new
                        {
                            SchoolClassId = 2,
                            SchoolClassName = "2B"
                        });
                });

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.SchoolClassCourse", b =>
                {
                    b.Property<int>("SchoolClassCourseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("fkCourseId")
                        .HasColumnType("int");

                    b.Property<int>("fkSchoolClassId")
                        .HasColumnType("int");

                    b.HasKey("SchoolClassCourseId");

                    b.HasIndex("fkCourseId");

                    b.HasIndex("fkSchoolClassId");

                    b.ToTable("SchoolClassCourses");

                    b.HasData(
                        new
                        {
                            SchoolClassCourseId = 1,
                            fkCourseId = 1,
                            fkSchoolClassId = 1
                        },
                        new
                        {
                            SchoolClassCourseId = 2,
                            fkCourseId = 2,
                            fkSchoolClassId = 2
                        });
                });

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fkSchoolClassId")
                        .HasColumnType("int");

                    b.Property<int>("fkStudentTeacherId")
                        .HasColumnType("int");

                    b.HasKey("StudentId");

                    b.HasIndex("fkSchoolClassId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            Age = 12,
                            FirstName = "Adam",
                            Gender = "M",
                            LastName = "Jansson",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            Age = 12,
                            FirstName = "Jenny",
                            Gender = "F",
                            LastName = "LindKvist",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 3,
                            Age = 12,
                            FirstName = "Marcus",
                            Gender = "M",
                            LastName = "Jonsson",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 4,
                            Age = 12,
                            FirstName = "Anna",
                            Gender = "F",
                            LastName = "Wiklund",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 5,
                            Age = 12,
                            FirstName = "Johannes",
                            Gender = "M",
                            LastName = "Öberg",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 6,
                            Age = 12,
                            FirstName = "Adam",
                            Gender = "M",
                            LastName = "Sundqvist",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 7,
                            Age = 12,
                            FirstName = "Linus",
                            Gender = "M",
                            LastName = "Lundgren",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 8,
                            Age = 12,
                            FirstName = "Hamphus",
                            Gender = "M",
                            LastName = "Stenberg",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 9,
                            Age = 12,
                            FirstName = "Linda",
                            Gender = "F",
                            LastName = "Lundgren",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        },
                        new
                        {
                            StudentId = 10,
                            Age = 12,
                            FirstName = "Julia",
                            Gender = "F",
                            LastName = "Nygren",
                            fkSchoolClassId = 1,
                            fkStudentTeacherId = 1
                        });
                });

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("fkCourseId")
                        .HasColumnType("int");

                    b.HasKey("TeacherId");

                    b.HasIndex("fkCourseId");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            TeacherId = 1,
                            Age = 52,
                            FirstName = "Bengt",
                            Gender = "M",
                            LastName = "Svensson",
                            fkCourseId = 1
                        },
                        new
                        {
                            TeacherId = 2,
                            Age = 42,
                            FirstName = "Sara",
                            Gender = "F",
                            LastName = "Häggkvist",
                            fkCourseId = 2
                        },
                        new
                        {
                            TeacherId = 3,
                            Age = 38,
                            FirstName = "Linus",
                            Gender = "M",
                            LastName = "Skalare",
                            fkCourseId = 3
                        });
                });

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.SchoolClassCourse", b =>
                {
                    b.HasOne("Labb2.Net21LinQKimWiklund.Models.Course", "Courses")
                        .WithMany("SchoolClassCourses")
                        .HasForeignKey("fkCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2.Net21LinQKimWiklund.Models.SchoolClass", "SchoolClasses")
                        .WithMany("SchoolClassCourses")
                        .HasForeignKey("fkSchoolClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.Student", b =>
                {
                    b.HasOne("Labb2.Net21LinQKimWiklund.Models.SchoolClass", "SchoolClasses")
                        .WithMany("Students")
                        .HasForeignKey("fkSchoolClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2.Net21LinQKimWiklund.Models.Teacher", b =>
                {
                    b.HasOne("Labb2.Net21LinQKimWiklund.Models.Course", "Courses")
                        .WithMany("Teachers")
                        .HasForeignKey("fkCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
