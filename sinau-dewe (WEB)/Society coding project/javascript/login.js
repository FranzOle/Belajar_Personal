document.addEventListener("DOMContentLoaded", function() {
    const form = document.querySelector("form");
    const loginButton = form.querySelector(".login-button");
    const loginContainer = document.querySelector(".login-container");
    
    form.addEventListener("submit", function(event) {
      event.preventDefault();
      loginContainer.innerHTML = `
        <h2>You've been logged in</h2>
        <p><a href="navbar.html">Back to main page</a></p>
      `;
    });
  });