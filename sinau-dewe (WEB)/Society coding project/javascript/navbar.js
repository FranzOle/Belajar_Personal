const loginLink = document.querySelector('a[href="#login"]');
const bootcampLink = document.querySelector('a[href="#bootcamp"]');

loginLink.addEventListener('click', () => {
    alert("You clicked on the Login link!");
});

bootcampLink.addEventListener('click', () => {
    alert("You clicked on the Bootcamp link!");
});

