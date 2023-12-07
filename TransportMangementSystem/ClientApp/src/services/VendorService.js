export default class VenderService {
    constructor() {

        const venders = [
            {
                Id: 1,
                Name: "aditya vender",
                vehicle: 11,
                ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
            },
            {
                Id: 2,
                Name: "sourabh vender",
                vehicle: 11,
                ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
            },
            {
                Id: 3,
                Name: "pasha vender",
                vehicle: 11,
                ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
            }
        ]
    }

    GetAllVenders() {
        return [
            {
                Id: 1,
                Name: "aditya vender",
                vehicle: 11,
                ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
            },
            {
                Id: 2,
                Name: "sourabh vender",
                vehicle: 11,
                ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
            },
            {
                Id: 3,
                Name: "pasha vender",
                vehicle: 11,
                ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
            }
        ];
    }
    DeleteVender(venderId) {
        return true
    }
    GetVenderDetails(venderId) {
        return {
            Id: venderId,
            Name: "pasha vender",
            vehicle: 11,
            ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
        }
    }

}