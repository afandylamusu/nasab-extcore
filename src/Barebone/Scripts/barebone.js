﻿// Copyright © 2017 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

(function (application) {
})(window.application = window.application || {});

$(document).ready(
    function () {
        $('.input-validation-error').tooltip({
            placement: 'right',
            title: function () {
                return $(this).attr('data-val-required');
            }
        });
    }
);