SELECT Product.Name, Category.Name
FROM ProductCategory
JOIN Category ON Category.Id = ProductCategory.CategoryId
RIGHT JOIN Product ON Product.Id = ProductCategory.ProductId