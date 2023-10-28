// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const deleteConfirmation = () => {
    if (confirm('Are you sure you want to delete this item?')) {
        return true; // Proceed with form submission
    } else {
        return false; // Cancel form submission
    }
}
