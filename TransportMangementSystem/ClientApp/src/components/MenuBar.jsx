import React from 'react';
import { Menubar } from 'primereact/menubar';
import {useNavigate} from 'react-router-dom'

export default function MenuBar(props) {
    const navigate = useNavigate();

   
    const items = [
        {
            label: 'Home',
            icon: 'pi pi-fw pi-home',
            command: (event) => { navigate("/") }
        },
        {
            label: 'Venders',
            icon: 'pi pi-fw pi-users',
            command: (event) => { navigate("/vender") }
        }
    ];

    const menustart = (
        <>
            <span>
                <img style={{ width: "50px", height: "50px" }} src="/TMSlogo.png" alt="no image" srcset="" />
            </span>
        </>
    )
    const menuend = (
        <>
            <span>
                Welcome Sourabh
            </span>
        </>
    )

    return (
        <div className="card">
            <Menubar style={{ backgroundColor: 'var(--primary-200)' }} model={items} end={menuend} start={menustart} />
        </div>
    )
}
