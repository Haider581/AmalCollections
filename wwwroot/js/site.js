var sv = [];

function RecallSV(id, c) {
    sv = [];
    return $.ajax({
        type: 'Get',
        url: '/' + c + '/GetAllBy',
        data: { id: id },
        success: function (dat) {
            if (dat.length > 0) {
                $.each(dat, function (i) {
                    var d = { Id: dat[i].id, Name: dat[i].name };
                    sv.push(d);
                })
            }
        }

    })
}

//Select 2
function initSelect(select, type) {
    select.select2({
        placeholder: 'Select ' + type,
        allowClear: true
    });
}
function AITL(select, list) {
    if (select != null && list.length > 0) {
        select.html('');
        $.each(list, function (i) {
            var op = '<option value="' + list[i].Id + '">' + list[i].Name + '<option/>';
            select.append(op);
        })
    }
}

function CurrentDate() {
    var date = new Date();
    var year = date.getFullYear().toString();
    var month = (date.getMonth() + 1).toString();
    var day = date.getDate().toString();
    if (parseInt(month) < 10) {
        month = "0" + month;
    }
    if (parseInt(day) < 10) {
        day = "0" + day;
    }
    return year + '-' + month + '-' + day;
}

//Modal
function ModalPopup(modalBody, c, a, id) {
    if (modalBody != null) {
        modalBody.html('');
        if (id == 0) {
            $.ajax({
                type: 'Get',
                url: '/' + c + '/' + a,
                success: function (dat) {
                    if (dat != null) {
                        modalBody.html(dat);
                    }
                }
            })
        }
        else {
            $.ajax({
                type: 'Get',
                url: '/' + c + '/' + a,
                data: { id: id },
                success: function (dat) {
                    if (dat != null) {
                        modalBody.html(dat);
                        $('#myModal').modal('show');
                    }
                }
            })
        }
    }
}
function ModalAdd(data, c, a) {
    var select = ModalSelect;
    $.ajax({
        type: 'Post',
        url: '/' + c + '/' + a,
        data: { vm: data },
        success: function (dat) {
            if (dat.includes('Error')) {
                alert(dat);
            }
            else {
                if (select != null) {
                    if (data.IsActive || select.attr('Id') == 'UomId') {
                        var op = '<option value="' + dat + '">' + data.Name + '</option>';
                        select.append(op);
                        select.val(dat).trigger('change');
                    }
                }
                $('#myModal').modal('hide');
            }
        }
    })
}
function ModalEdit(data, c, a) {
    var select = ModalSelect;
    $.ajax({
        type: 'Post',
        url: '/' + c + '/' + a,
        data: { vm: data },
        success: function (dat) {
            if (dat.includes('Error')) {
                alert(dat);
            }
            else {
                if (select != null) {
                    select.find('option[value="' + dat + '"]').remove();
                    if (data.IsActive || select.attr('Id') == 'UomId') {
                        var op = '<option value="' + dat + '">' + data.Name + '</option>';
                        select.append(op);
                        select.val(dat).trigger('change');
                    }
                }
                $('#myModal').modal('hide');
            }
        }
    })
}
function ModalRemove(id, c, a) {
    var select = ModalSelect;
    $.ajax({
        type: 'Post',
        url: '/' + c + '/' + a,
        data: { id: id },
        success: function (dat) {
            if (dat.includes('Error')) {
                alert(dat);
            }
            else {
                if (select != null) {
                    select.find('option[value="' + id + '"]').remove();
                }
            }
        }
    })
}

//cart function
function CartTotal() {
    $.ajax({
        type: 'Get',
        url: '/Cart/CartTotal',
        success: function (dat) {
            $('.cartcount').text(dat);
        }
    })
}
function AddToCart(id, qty) {
    return $.ajax({
        type: 'Post',
        url: '/Cart/Add',
        data: { ProductId: id, Qty: qty },
        success: function (dat) {
            if (dat.includes('Error')) {
                $.alert({
                    title: 'Error',
                    content: dat,
                    theme: 'supervan',
                })
                return;
            }
            else {
                $('.cartcount').text(dat);
            }
            
        }
    })
}
function Remove(id) {
    return $.ajax({
        type: 'Get',
        url: '/Cart/Remove',
        data: { id: id },
        success: function (dat) {
            if (dat.includes('Error')) {
                $.alert({
                    title: 'Error',
                    content: dat,
                    theme: 'supervan',
                })
                return;
            }
            else {
                window.location.reload();
            }

        }
    })
}

function Calc() {
    var ul = $('.cart_items_list');
    var li = ul.find('li');
    var grandTotal = 0;
    var qty, total, rate = 0;

    $.each(li, function () {
        var li = $(this);
        var qty = parseFloat(li.find('.Qty').text());
        var rate = parseFloat(li.find('.Rate').text());
        var total = qty * rate;
        grandTotal += total;
        li.find('.totalAmount').text(total);
    })
    $('.SubTotal').text(grandTotal);
    $('.GrandTotal').text(grandTotal);
}