
$(document).ready(function () {

    $(function () {
        $('.user-select-list').change(function () {
            var x = $(this).val();
            $('#selected-user-id').val(x);
        });
    });


    $(function () {
        $('#user-submit').click(function () {
            var listItems = $('.user-row');
            var userId = $('#selected-user-id').val();
            listItems.hide();
            if (userId === "0") {
                $('.user-row').show();
            }
            else {
                $('.user-' + userId).show();

            }

        });
    });
});