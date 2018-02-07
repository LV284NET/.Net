﻿using EasyTravelWeb.Repositories;
using System.Web.Http;
using System.Collections.Generic;
using EasyTravelWeb.Models;
using System.Net;
using EasyTravelWeb.Infrastructure.Validators;

namespace EasyTravelWeb.Controllers
{
    /// <summary>
    ///		Controller for Profile page
    /// </summary>
    public class ProfileController : ApiController
    {
        #region Private Fields

        /// <summary>
        ///		Instance of UserRepository, using methods to do actions with database
        /// </summary>
        private readonly UserRepository userRepository = new UserRepository();


        /// <summary>
        ///		Instance of RatingRepository, using methods to do actions with database
        /// </summary>
        private readonly RatingRepository ratingRepository = new RatingRepository();

        /// <summary>
        ///		Validator for first and last name
        /// </summary>
        private readonly IValidator<string> nameValidator =
            new NameValidator();

        /// <summary>
        ///		Instance of PlaceRepository, using method to get favourite places for user from database
        /// </summary>
        private readonly PlaceRepository placeRepository = new PlaceRepository();

        #endregion

        #region Constructors

        /// <summary>
        ///     Default constructor
        /// </summary>
        public ProfileController() { }

        /// <summary>
        ///    
        /// </summary>
        public ProfileController(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        /// <summary>
        ///    
        /// </summary>
        public ProfileController(PlaceRepository placeRepository)
        {
            this.placeRepository = placeRepository;
        }

        #endregion

        #region Public Controllers

        /// <summary>
        ///		Method for getting User from Db
        /// </summary>
        /// <param name="id">id of current user</param>
        /// <returns>First, last, email of user</returns>
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetUserInfo(int id)
        {
            User user = this.userRepository.GetUser(id);

            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        ///		Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="firstName">First name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [Authorize]
        [HttpPost]
        public IHttpActionResult ChangeFirstName(int id, string firstName)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (this.nameValidator.IsValid(firstName))
            {
                this.userRepository.ChangeFirstName(id, firstName);
            }

            return this.Ok();
        }

        /// <summary>
        ///		Method for changing first name of a user
        /// </summary>
        /// <param name="id">Id of current user</param>
        /// <param name="lastName">Last name which will be updated in database</param>
        /// <returns>result of chaning (Bad or Ok)</returns>
        [Authorize]
        [HttpPost]
        public IHttpActionResult ChangeLastName(int id, string lastName)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            if (this.nameValidator.IsValid(lastName))
            {
                this.userRepository.ChangeLastName(id, lastName);
            }

            return this.Ok();
        }

        /// <summary>
        /// Cotroller fo getting favorite places of specific user
        /// </summary>
        /// <param name="id">ID of current user</param>
        /// <returns>List of favourite Places</returns>
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetFavoritePlaces(int id)
        {
            List<Place> cityPlaces = this.placeRepository.GetFavoritePlaces(id);

            if (cityPlaces == null)
            {
                return NotFound();
            }
            return Ok(cityPlaces);
        }

        /// <summary>
        /// Cotroller fo setting rating of place of specific user
        /// </summary>
        /// <param name="userRating"> Model UserPlaceRating</param>
        /// <returns>Status code for request</returns>
        [Authorize]
        [HttpPost]
        public IHttpActionResult SetUserRatingForPlace([FromBody] UserPlaceRating userRating)
        {
            if (this.ratingRepository.SetUserRatingForPlace(userRating))
            {
                return this.Ok();
            }

            return this.Content(HttpStatusCode.BadRequest, "Something was wrong. Try again");
        }

        /// <summary>
        /// Cotroller fo delete rating of place of specific user
        /// </summary>
        /// <param name="userRating"> Model UserPlaceRating</param>
        /// <returns>Status code for request</returns>
        [Authorize]
        [HttpDelete]
        public IHttpActionResult DeleteUserRatingForPlace([FromBody] UserPlaceRating userRating)
        {
            if (this.ratingRepository.DeleteUserRatingForPlace(userRating.UserId, userRating.PlaceId))
            {
                return Ok();
            }

            return this.Content(HttpStatusCode.BadRequest, "Something was wrong. Try again");
        }

        /// <summary>
        /// Cotroller fo getting rating place of specific user
        /// </summary>
        /// <param name="userId">ID of current user</param>
        /// <param name="placeId">ID of current place</param>
        /// <returns>Status code with user rating of place</returns>
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetUserRatingOfPlace(int userId, long placeId)
        {
            return this.Ok(this.ratingRepository.GetUserRatingOfPlace(userId, placeId));                
        }

        #endregion
    }
}
