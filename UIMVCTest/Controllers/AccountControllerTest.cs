﻿using System;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UI;
using UI.Controllers;
using UI.Models;

namespace UI.Tests.Controllers
{

    [TestClass]
    public class CustomerControllerTest
    {

        [TestMethod]
        public void ChangePassword_Get_ReturnsView()
        {
            // Arrange
            CustomerController controller = GetCustomerController();

            // Act
            ActionResult result = controller.ChangePassword();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(10, ((ViewResult)result).ViewData["PasswordLength"]);
        }

        [TestMethod]
        public void ChangePassword_Post_ReturnsRedirectOnSuccess()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            ChangePasswordModel model = new ChangePasswordModel()
            {
                OldPassword = "goodOldPassword",
                NewPassword = "goodNewPassword",
                ConfirmPassword = "goodNewPassword"
            };

            // Act
            ActionResult result = controller.ChangePassword(model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
            RedirectToRouteResult redirectResult = (RedirectToRouteResult)result;
            Assert.AreEqual("ChangePasswordSuccess", redirectResult.RouteValues["action"]);
        }

        [TestMethod]
        public void ChangePassword_Post_ReturnsViewIfChangePasswordFails()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            ChangePasswordModel model = new ChangePasswordModel()
            {
                OldPassword = "goodOldPassword",
                NewPassword = "badNewPassword",
                ConfirmPassword = "badNewPassword"
            };

            // Act
            ActionResult result = controller.ChangePassword(model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = (ViewResult)result;
            Assert.AreEqual(model, viewResult.ViewData.Model);
            Assert.AreEqual("The current password is incorrect or the new password is invalid.", controller.ModelState[""].Errors[0].ErrorMessage);
            Assert.AreEqual(10, viewResult.ViewData["PasswordLength"]);
        }

        [TestMethod]
        public void ChangePassword_Post_ReturnsViewIfModelStateIsInvalid()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            ChangePasswordModel model = new ChangePasswordModel()
            {
                OldPassword = "goodOldPassword",
                NewPassword = "goodNewPassword",
                ConfirmPassword = "goodNewPassword"
            };
            controller.ModelState.AddModelError("", "Dummy error message.");

            // Act
            ActionResult result = controller.ChangePassword(model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = (ViewResult)result;
            Assert.AreEqual(model, viewResult.ViewData.Model);
            Assert.AreEqual(10, viewResult.ViewData["PasswordLength"]);
        }

        [TestMethod]
        public void ChangePasswordSuccess_ReturnsView()
        {
            // Arrange
            CustomerController controller = GetCustomerController();

            // Act
            ActionResult result = controller.ChangePasswordSuccess();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void LogOff_LogsOutAndRedirects()
        {
            // Arrange
            CustomerController controller = GetCustomerController();

            // Act
            ActionResult result = controller.LogOff();

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
            RedirectToRouteResult redirectResult = (RedirectToRouteResult)result;
            Assert.AreEqual("Home", redirectResult.RouteValues["controller"]);
            Assert.AreEqual("Index", redirectResult.RouteValues["action"]);
            Assert.IsTrue(((MockFormsAuthenticationService)controller.FormsService).SignOut_WasCalled);
        }

        [TestMethod]
        public void LogOn_Get_ReturnsView()
        {
            // Arrange
            CustomerController controller = GetCustomerController();

            // Act
            ActionResult result = controller.LogOn();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void LogOn_Post_ReturnsRedirectOnSuccess_WithoutReturnUrl()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            LogOnModel model = new LogOnModel()
            {
                UserName = "someUser",
                Password = "goodPassword",
                RememberMe = false
            };

            // Act
            ActionResult result = controller.LogOn(model, null);

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
            RedirectToRouteResult redirectResult = (RedirectToRouteResult)result;
            Assert.AreEqual("Home", redirectResult.RouteValues["controller"]);
            Assert.AreEqual("Index", redirectResult.RouteValues["action"]);
            Assert.IsTrue(((MockFormsAuthenticationService)controller.FormsService).SignIn_WasCalled);
        }

        [TestMethod]
        public void LogOn_Post_ReturnsRedirectOnSuccess_WithReturnUrl()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            LogOnModel model = new LogOnModel()
            {
                UserName = "someUser",
                Password = "goodPassword",
                RememberMe = false
            };

            // Act
            ActionResult result = controller.LogOn(model, "/someUrl");

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectResult));
            RedirectResult redirectResult = (RedirectResult)result;
            Assert.AreEqual("/someUrl", redirectResult.Url);
            Assert.IsTrue(((MockFormsAuthenticationService)controller.FormsService).SignIn_WasCalled);
        }

        [TestMethod]
        public void LogOn_Post_ReturnsViewIfModelStateIsInvalid()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            LogOnModel model = new LogOnModel()
            {
                UserName = "someUser",
                Password = "goodPassword",
                RememberMe = false
            };
            controller.ModelState.AddModelError("", "Dummy error message.");

            // Act
            ActionResult result = controller.LogOn(model, null);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = (ViewResult)result;
            Assert.AreEqual(model, viewResult.ViewData.Model);
        }

        [TestMethod]
        public void LogOn_Post_ReturnsViewIfValidateUserFails()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            LogOnModel model = new LogOnModel()
            {
                UserName = "someUser",
                Password = "badPassword",
                RememberMe = false
            };

            // Act
            ActionResult result = controller.LogOn(model, null);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = (ViewResult)result;
            Assert.AreEqual(model, viewResult.ViewData.Model);
            Assert.AreEqual("The user name or password provided is incorrect.", controller.ModelState[""].Errors[0].ErrorMessage);
        }

        [TestMethod]
        public void Register_Get_ReturnsView()
        {
            // Arrange
            CustomerController controller = GetCustomerController();

            // Act
            ActionResult result = controller.Register();

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            Assert.AreEqual(10, ((ViewResult)result).ViewData["PasswordLength"]);
        }

        [TestMethod]
        public void Register_Post_ReturnsRedirectOnSuccess()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            RegisterModel model = new RegisterModel()
            {
                UserName = "someUser",
                Email = "goodEmail",
                Password = "goodPassword",
                ConfirmPassword = "goodPassword"
            };

            // Act
            ActionResult result = controller.Register(model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(RedirectToRouteResult));
            RedirectToRouteResult redirectResult = (RedirectToRouteResult)result;
            Assert.AreEqual("Home", redirectResult.RouteValues["controller"]);
            Assert.AreEqual("Index", redirectResult.RouteValues["action"]);
        }

        [TestMethod]
        public void Register_Post_ReturnsViewIfRegistrationFails()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            RegisterModel model = new RegisterModel()
            {
                UserName = "duplicateUser",
                Email = "goodEmail",
                Password = "goodPassword",
                ConfirmPassword = "goodPassword"
            };

            // Act
            ActionResult result = controller.Register(model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = (ViewResult)result;
            Assert.AreEqual(model, viewResult.ViewData.Model);
            Assert.AreEqual("Username already exists. Please enter a different user name.", controller.ModelState[""].Errors[0].ErrorMessage);
            Assert.AreEqual(10, viewResult.ViewData["PasswordLength"]);
        }

        [TestMethod]
        public void Register_Post_ReturnsViewIfModelStateIsInvalid()
        {
            // Arrange
            CustomerController controller = GetCustomerController();
            RegisterModel model = new RegisterModel()
            {
                UserName = "someUser",
                Email = "goodEmail",
                Password = "goodPassword",
                ConfirmPassword = "goodPassword"
            };
            controller.ModelState.AddModelError("", "Dummy error message.");

            // Act
            ActionResult result = controller.Register(model);

            // Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
            ViewResult viewResult = (ViewResult)result;
            Assert.AreEqual(model, viewResult.ViewData.Model);
            Assert.AreEqual(10, viewResult.ViewData["PasswordLength"]);
        }

        private static CustomerController GetCustomerController()
        {
            CustomerController controller = new CustomerController()
            {
                FormsService = new MockFormsAuthenticationService(),
                MembershipService = new MockMembershipService()
            };
            controller.ControllerContext = new ControllerContext()
            {
                Controller = controller,
                RequestContext = new RequestContext(new MockHttpContext(), new RouteData())
            };
            return controller;
        }

        private class MockFormsAuthenticationService : IFormsAuthenticationService
        {
            public bool SignIn_WasCalled;
            public bool SignOut_WasCalled;

            public void SignIn(string userName, bool createPersistentCookie)
            {
                // verify that the arguments are what we expected
                Assert.AreEqual("someUser", userName);
                Assert.IsFalse(createPersistentCookie);

                SignIn_WasCalled = true;
            }

            public void SignOut()
            {
                SignOut_WasCalled = true;
            }
        }

        private class MockHttpContext : HttpContextBase
        {
            private readonly IPrincipal _user = new GenericPrincipal(new GenericIdentity("someUser"), null /* roles */);

            public override IPrincipal User
            {
                get
                {
                    return _user;
                }
                set
                {
                    base.User = value;
                }
            }
        }

        private class MockMembershipService : IMembershipService
        {
            public int MinPasswordLength
            {
                get { return 10; }
            }

            public bool ValidateUser(string userName, string password)
            {
                return (userName == "someUser" && password == "goodPassword");
            }

            public MembershipCreateStatus CreateUser(string userName, string password, string email)
            {
                if (userName == "duplicateUser")
                {
                    return MembershipCreateStatus.DuplicateUserName;
                }

                // verify that values are what we expected
                Assert.AreEqual("goodPassword", password);
                Assert.AreEqual("goodEmail", email);

                return MembershipCreateStatus.Success;
            }

            public bool ChangePassword(string userName, string oldPassword, string newPassword)
            {
                return (userName == "someUser" && oldPassword == "goodOldPassword" && newPassword == "goodNewPassword");
            }
        }

    }
}
