"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var RouteGuard = /** @class */ (function () {
    function RouteGuard() {
    }
    RouteGuard.prototype.canActivate = function (route, state) {
        //se usuario autenticado
        return true;
    };
    return RouteGuard;
}());
exports.RouteGuard = RouteGuard;
//# sourceMappingURL=route.guard.js.map