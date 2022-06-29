/**
 * Hướng dẫn sử dụng
 * 
 * <script src="./js/validator1.js"></script>
    <script>
        Validator({
            form: "#form1",  //id của form
            formGroupSelecter: '.form-group',  //class của group form
            errorSelector: '.form-message', //class của thẻ message error
            rules: [
                Validator.isRequired('#hoten'), //nhập id của chổ bắt buộc nhập
                Validator.isRequired('input[name="gioitinh"]'), //nếu input khác text và file
                Validator.minLength('#password', 3), //cần tối thiểu bao nhiêu kí tự
                Validator.isConfirm('#re-password', function() {
                    return document.querySelector('#form1 #password').value;
                }, 'Mật khẩu nhập lại không chính xác')
            ],

            //Nếu không muốn submit với hành vi mặc định thì thêm đoạn này vào, còn muốn submit lên server thì khỏi thêm
            onSubmit: function(data) {
                //Call API
                console.log(data);
            }
        });
    </script>
 * 
 */






//Đối tượng
function Validator(options) {
    function getParent(element, selector) {
        while (element.parentElement) {
            if (element.parentElement.matches(selector)) {
                return element.parentElement;
            }
            element = element.parentElement;
        }
    }

    var selectorRules = {};

    //Hàm thực hiện validate
    function validate(inputElement, rule) {
        var errorMessage;
        var errorElement = getParent(inputElement, options.formGroupSelecter).querySelector(
            options.errorSelector
        );

        //Lấy ra các rules của selector
        var rules = selectorRules[rule.selector];
        //Lặp qua từng rule va kiểm tra
        for (var i = 0; i < rules.length; i++) {
            switch (inputElement.type) {
                case 'radio':
                case 'checkbox':
                    errorMessage = rules[i](
                        formElement.querySelector(rule.selector + ':checked')
                    );
                    break;
                default:
                    errorMessage = rules[i](inputElement.value);
            }
            if (errorMessage) break;
        }

        if (errorMessage) {
            errorElement.innerText = errorMessage;
            getParent(inputElement, options.formGroupSelecter).classList.add("invalid");
        } else {
            errorElement.innerText = "";
            getParent(inputElement, options.formGroupSelecter).classList.remove("invalid");
        }

        return !errorMessage;
    }

    //Lấy element của form cần validate
    var formElement = document.querySelector(options.form);
    if (formElement) {

        //Khi submit form
        formElement.onsubmit = function(e) {
            e.preventDefault();

            var isFormValid = true;
            //Lặp qua từng rule và validate luôn
            options.rules.forEach(function(rule) {
                var inputElement = formElement.querySelector(rule.selector);
                var isValid = validate(inputElement, rule);
                if (!isValid) {
                    isFormValid = false;
                }
            });

            if (isFormValid) {
                //Trường hợp submit với javascript
                if (typeof options.onSubmit === 'function') {
                    var enabledInput = formElement.querySelectorAll('[name]:not([disable])');
                    var formValues = Array.from(enabledInput).reduce(function(values, input) {
                        switch (input.type) {
                            case 'radio':
                                values[input.name] = formElement.querySelector('input[name="' + input.name + '"]:checked').value;

                                break;
                            case 'checkbox':
                                if (!input.matches(':checked')) {
                                    values[input.name] = ''
                                    return values;
                                }
                                if (!Array.isArray(values[input.name])) {
                                    values[input.name] = []
                                }
                                values[input.name].push(input.value)
                                break;
                            case 'file':
                                values[input.name] = input.files;
                                break;
                            default:
                                values[input.name] = input.value
                        }
                        return values;
                    }, {});
                    options.onSubmit(formValues);
                    //Trường hợp submit với hành vi mặc định
                } else {
                    formElement.submit();
                }
            }
        }

        //Lặp qua mỗi rule và xủ lý(lắng nghe sự kiện blur, input, ...)
        options.rules.forEach(function(rule) {
            //Lưu lại các rule trong mỗi input
            if (Array.isArray(selectorRules[rule.selector])) {
                selectorRules[rule.selector].push(rule.test);
            } else {
                selectorRules[rule.selector] = [rule.test];
            }
            var inputElements = formElement.querySelectorAll(rule.selector);

            Array.from(inputElements).forEach(function(inputElement) {
                //Xử lí trường hợp blur khỏi input
                inputElement.onblur = function() {
                    //value: inputElement.values
                    //test: rules.test
                    validate(inputElement, rule);
                };
                //Xử lí mỗi khi người dùng nhập vào input
                inputElement.oninput = function() {
                    var errorElement = getParent(inputElement, options.formGroupSelecter).querySelector(
                        options.errorSelector
                    );
                    errorElement.innerText = "";
                    getParent(inputElement, options.formGroupSelecter).classList.remove("invalid");
                };
            });

        });
    }
}

//Định nghĩa các rules
//Nguyên tắc của  các rule:
//1.Khi có lỗi: trả mesage lỗi
//2.Khi hợp lệ không trả ra gì cả(undefined)
Validator.isRequired = function(selector, message) {
    return {
        selector: selector,
        test: function(value) {
            return value ? undefined : message || "Vui lòng nhập trường này";
        },
    };
};

Validator.isEmail = function(selector, message) {
    return {
        selector: selector,
        test: function(value) {
            var regex = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
            return regex.test(value) ?
                undefined :
                message || "Trường này phải là email";
        },
    };
};

Validator.minLength = function(selector, min, message) {
    return {
        selector: selector,
        test: function(value) {
            return value.length >= min ?
                undefined :
                message || `Trường này tối thiểu ${min} kí tự`;
        },
    };
};

Validator.isConfirm = function(selector, getConfirmValue, message) {
    return {
        selector: selector,
        test: function(value) {
            return value === getConfirmValue() ?
                undefined :
                message || "Giá trị nhập vào không chính xác";
        },
    };
};