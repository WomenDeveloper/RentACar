using System;
using System.Runtime.Serialization;
using Core.Entities.Concreate;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Added a Car";
        public static string CarDeleted = "Deleted a Car";
        public static string CarUpdated = "Updated a Car";
        public static string CarGetById = "Successfuly gets car by id";
        public static string CarDetails = "Successfuly gets car details";
        public static string CarNameInvalid = "The Car name is invalid";
        public static string CarListed = "listed cars";

        public static string BrandListed = "Listed brands";
        public static string BrandGetById = "get the brand by brand id";
        public static string BrandAdded = "Added a Brand";
        public static string BrandDeleted = "Deleted a brand";
        public static string BrandUpdated = "Updated a brand";

        public static string ColorListed = "Listed colors";
        public static string ColorgetById = "get the color by color id";
        public static string ColorAdded = "Added a brand";
        public static string ColorDeleted = "Deleted a brand";
        public static string ColorUpdated = "Updated a brand";

        public static string RentalsListed = "listed rentals";
        public static string RentalGeyById = "Successfuly gets rental by id";
        public static string RentalAdded = "Added a rental";
        public static string RentalDeleted = "Deleted a rental";
        public static string RentalUpdated = "Updated a rental";

        public static string RentalErrorAdd = " Error add";

        public static string UserListed = "listed users";
        public static string UserAdded = "Added a user";
        public static string UserDeleted = "Deleted a user";
        public static string UserUpdated = "Updated a user";

        public static string CustomerAdded = "Added a customer";
        public static string CustomerDeleted = "Deleted a customer";
        public static string CustomerUpdated = "Updated a customer";
        public static string ListedCustomer = "listed  customers";
        public static string CarImageUpdated = "Car image updated";
        public static string CarImageAdded = "Car Image added";
        public static string CarImagesListed = "listed car images";
        public static string AuthorizationDenied = "Denied Authorization ";
        internal static string UserRegistered;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
    }
}

