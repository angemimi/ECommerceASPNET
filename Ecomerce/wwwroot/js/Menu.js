$(Document).find('#main-menu').off('click', 'ul.navbar-nav li a').on('click', 'ul.navbar-nav li a', function (e) {
	console.log('f');
});