﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EKartDataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EKartDBContext : DbContext
    {
        public EKartDBContext()
            : base("name=EKartDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual DbSet<CardDetail> CardDetails { get; set; }
    
        [DbFunction("EKartDBContext", "ufn_FecthCardDetails")]
        public virtual IQueryable<ufn_FecthCardDetails_Result> ufn_FecthCardDetails(Nullable<decimal> cardNumber)
        {
            var cardNumberParameter = cardNumber.HasValue ?
                new ObjectParameter("CardNumber", cardNumber) :
                new ObjectParameter("CardNumber", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufn_FecthCardDetails_Result>("[EKartDBContext].[ufn_FecthCardDetails](@CardNumber)", cardNumberParameter);
        }
    
        [DbFunction("EKartDBContext", "ufn_FetchProductDetails")]
        public virtual IQueryable<ufn_FetchProductDetails_Result> ufn_FetchProductDetails(Nullable<int> categoryId)
        {
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufn_FetchProductDetails_Result>("[EKartDBContext].[ufn_FetchProductDetails](@CategoryId)", categoryIdParameter);
        }
    
        [DbFunction("EKartDBContext", "ufn_GetShoppingCart")]
        public virtual IQueryable<ufn_GetShoppingCart_Result> ufn_GetShoppingCart()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ufn_GetShoppingCart_Result>("[EKartDBContext].[ufn_GetShoppingCart]()");
        }
    
        public virtual int usp_AddCardDetails(string cardNumber, string nameOnCard, string cardType, Nullable<decimal> cVVNumber, Nullable<System.DateTime> expiryDate, Nullable<decimal> balance)
        {
            var cardNumberParameter = cardNumber != null ?
                new ObjectParameter("CardNumber", cardNumber) :
                new ObjectParameter("CardNumber", typeof(string));
    
            var nameOnCardParameter = nameOnCard != null ?
                new ObjectParameter("NameOnCard", nameOnCard) :
                new ObjectParameter("NameOnCard", typeof(string));
    
            var cardTypeParameter = cardType != null ?
                new ObjectParameter("CardType", cardType) :
                new ObjectParameter("CardType", typeof(string));
    
            var cVVNumberParameter = cVVNumber.HasValue ?
                new ObjectParameter("CVVNumber", cVVNumber) :
                new ObjectParameter("CVVNumber", typeof(decimal));
    
            var expiryDateParameter = expiryDate.HasValue ?
                new ObjectParameter("ExpiryDate", expiryDate) :
                new ObjectParameter("ExpiryDate", typeof(System.DateTime));
    
            var balanceParameter = balance.HasValue ?
                new ObjectParameter("Balance", balance) :
                new ObjectParameter("Balance", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_AddCardDetails", cardNumberParameter, nameOnCardParameter, cardTypeParameter, cVVNumberParameter, expiryDateParameter, balanceParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_AddNewProduct(string productId, string productName, Nullable<byte> categoryId, Nullable<decimal> price, Nullable<int> quantityAvailable)
        {
            var productIdParameter = productId != null ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(string));
    
            var productNameParameter = productName != null ?
                new ObjectParameter("ProductName", productName) :
                new ObjectParameter("ProductName", typeof(string));
    
            var categoryIdParameter = categoryId.HasValue ?
                new ObjectParameter("CategoryId", categoryId) :
                new ObjectParameter("CategoryId", typeof(byte));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            var quantityAvailableParameter = quantityAvailable.HasValue ?
                new ObjectParameter("QuantityAvailable", quantityAvailable) :
                new ObjectParameter("QuantityAvailable", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_AddNewProduct", productIdParameter, productNameParameter, categoryIdParameter, priceParameter, quantityAvailableParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_AddPurchaseDetails(string emailId, string productId, Nullable<int> quantityPurchased, ObjectParameter purchaseId)
        {
            var emailIdParameter = emailId != null ?
                new ObjectParameter("EmailId", emailId) :
                new ObjectParameter("EmailId", typeof(string));
    
            var productIdParameter = productId != null ?
                new ObjectParameter("ProductId", productId) :
                new ObjectParameter("ProductId", typeof(string));
    
            var quantityPurchasedParameter = quantityPurchased.HasValue ?
                new ObjectParameter("QuantityPurchased", quantityPurchased) :
                new ObjectParameter("QuantityPurchased", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_AddPurchaseDetails", emailIdParameter, productIdParameter, quantityPurchasedParameter, purchaseId);
        }
    
        public virtual ObjectResult<Nullable<int>> usp_UpdateCardBalance(Nullable<decimal> cardNumber, string nameOnCard, string cardType, Nullable<decimal> cVVNumber, Nullable<System.DateTime> expiryDate, Nullable<decimal> price)
        {
            var cardNumberParameter = cardNumber.HasValue ?
                new ObjectParameter("CardNumber", cardNumber) :
                new ObjectParameter("CardNumber", typeof(decimal));
    
            var nameOnCardParameter = nameOnCard != null ?
                new ObjectParameter("NameOnCard", nameOnCard) :
                new ObjectParameter("NameOnCard", typeof(string));
    
            var cardTypeParameter = cardType != null ?
                new ObjectParameter("CardType", cardType) :
                new ObjectParameter("CardType", typeof(string));
    
            var cVVNumberParameter = cVVNumber.HasValue ?
                new ObjectParameter("CVVNumber", cVVNumber) :
                new ObjectParameter("CVVNumber", typeof(decimal));
    
            var expiryDateParameter = expiryDate.HasValue ?
                new ObjectParameter("ExpiryDate", expiryDate) :
                new ObjectParameter("ExpiryDate", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("usp_UpdateCardBalance", cardNumberParameter, nameOnCardParameter, cardTypeParameter, cVVNumberParameter, expiryDateParameter, priceParameter);
        }
    }
}