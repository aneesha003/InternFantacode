using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
public class ProductController : Controller
{
    private readonly ProductRepository productRepository;
    public ProductController()
    {
        productRepository = new ProductRepository();
    }
    // GET: api/values
    [HttpGet]
    public IEnumerable<Product> Get() => productRepository.GetAll();

    // GET api/values/5
    [HttpGet("{id}")]
    public Product Get(int id)
    {
        return productRepository.GetByID(id);
    }

    // POST api/values
    [HttpPost]
    public void Post([FromBody]Product prod)
    {
        if (ModelState.IsValid)
            productRepository.Add(prod);
    }

    // PUT api/values/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Product prod)
    {
        prod.ProductId = id;
        if (ModelState.IsValid)
            productRepository.Update(prod);
    }

    // DELETE api/values/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        productRepository.Delete(id);
    }
}