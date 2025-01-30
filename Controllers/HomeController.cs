using System.Data;
using System.Diagnostics;
using Dapper;
using MenuSistemi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MenuSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDbConnection _connection;

        public HomeController(IDbConnection connection)
        {
                _connection = connection;
        }
        public IActionResult Index(int? Id)
        {
            var categoryList = _connection.Query<TBLCategory>("SELECT * FROM TBLCategory").ToList();
            var menuLeftJoin = _connection.Query<MenuLeftJoinCategory>("SELECT * FROM TBLMenu LEFT JOIN TBLCategory ON TBLMenu.CategoryId = TBLCategory.Id").ToList();
            var categorySum = _connection.Query<CategoryMenuCount>
                                                                (
                                                                 @"SELECT TBLMenu.CategoryId,TBLCategory.CategoryName,COUNT(TBLMenu.Id) AS MenuSayisi
                                                                  FROM TBLMenu
                                                                  LEFT JOIN TBLCategory
                                                                  ON 
                                                                  TBLMenu.CategoryId = TBLCategory.Id
                                                                  GROUP BY TBLMenu.CategoryId, TBLCategory.CategoryName;"
                                                                 ).ToList();
            var viewModel = new MenuWithCategory()
            {
                
                Category = categoryList,
                MenuLeftJoin = menuLeftJoin,
                MenuCount = categorySum
                
            }; 

            return View(viewModel);
        }

        public IActionResult Editor(int? Id) 
        {
            var categoryList = _connection.Query<TBLCategory>("SELECT * FROM TBLCategory").ToList();
            var menuLeftJoin = _connection.Query<MenuLeftJoinCategory>("SELECT * FROM TBLMenu LEFT JOIN TBLCategory ON TBLMenu.CategoryId = TBLCategory.Id").ToList();
            var viewModel = new MenuWithCategory()
            {

                Category = categoryList,
                MenuLeftJoin = menuLeftJoin

            };

            ViewBag.Id = Id;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult AddCategory(TBLCategory category) 
        {
            var addCategory = _connection.Execute
                (
                  @"INSERT INTO TBLCategory
                    (CategoryName)
                    VALUES
                    (@CategoryName)", category
                );
            return RedirectToAction("Editor");
        }

        [HttpPost]
        public IActionResult UpdateCategory(TBLCategory category) 
        {
            var updateCategory = _connection.Execute
                                                    (
                                                      @"UPDATE  TBLCategory
                                                        SET
                                                        CategoryName = @CategoryName
                                                        WHERE
                                                        Id=@Id",category
                                                    );

            return RedirectToAction("Editor");
        }

        public IActionResult DeleteCategory(int Id) 
        {
            var deleteCategory = _connection.Execute("DELETE FROM TBLCategory WHERE Id=@Id", new {Id});
            return RedirectToAction("Editor"); 
        }

        public IActionResult ProductManager(int Id)
        {
            var menuLeftJoin = _connection.Query<MenuLeftJoinCategory>("SELECT * FROM TBLMenu LEFT JOIN TBLCategory ON TBLMenu.CategoryId = TBLCategory.Id WHERE CategoryId = @CategoryId", new { CategoryId = Id } ).ToList();
            var baslikYazisi = _connection.QueryFirstOrDefault<TBLCategory>("SELECT CategoryName From TBLCategory Where Id = @Id", new {Id});
            ViewBag.Baslik = baslikYazisi.CategoryName;
            return View(menuLeftJoin);
        }



    }
}
