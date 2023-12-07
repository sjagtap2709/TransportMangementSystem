import React, { useState, useRef, useEffect } from 'react'
import { Card } from 'primereact/card'
import { Button } from 'primereact/button';
import { Dialog } from 'primereact/dialog';
import { ConfirmDialog, confirmDialog } from 'primereact/confirmdialog';
import { Toast } from 'primereact/toast';

import VenderService from '../services/VendorService'
var venderService = new VenderService();

export default function Vender() {
    const [venders, setVenders] = useState(venderService.GetAllVenders());
    const [visible, setVisible] = useState(false);
    const [id, setId] = useState(4);

    const toast = useRef(null);
    const DeleteAccepted = (id) => {
        if (venderService.DeleteVender(id)) {
            setVenders((current) =>
                current.filter((v) => v.Id !== id));
            toast.current.show({ severity: 'success', summary: 'Deleted', detail: 'Deleted vender', life: 3000 });

        } else {

            toast.current.show({ severity: 'warn', summary: 'Error', detail: 'Error while deleting vender', life: 3000 });
        }
    }

    useEffect(() => {
        console.log("rendered vender change")
    }, [venders]);


    const DeleteRejected = () => {
        toast.current.show({ severity: 'warn', summary: 'Rejected', detail: 'You have rejected', life: 3000 });
    }

    function DeleteClick(id) {
        confirmDialog({
            message: 'Do you want to delete this record?',
            header: 'Delete Confirmation',
            icon: 'pi pi-info-circle',
            acceptClassName: 'p-button-danger',
            accept: () => DeleteAccepted(id),
            reject: DeleteRejected
        });

    }
    function ViewClick(id) {
        alert(id)
        setVisible(true);
    }
    function onHideViewVender(state) {
        setVisible(state)
    }

    return (
        <>

            <ViewVender
                onHide={onHideViewVender}
                visible={visible}
            ></ViewVender>
            <Toast ref={toast} />
            <ConfirmDialog />
            <button onClick={() => {
                setVenders([...venders, {
                    Id: id,
                    Name: "aditya vender",
                    vehicle: 11,
                    ImgUrl: "https://primefaces.org/cdn/primereact/images/usercard.png"
                }]);
                setId(id + 1);
            }}>Add one more</button>
            <div>
                {
                    venders.map(item => {
                        return (
                            <div key={item.Id} style={{ float: "left", margin: "15px" }}>
                                <VenderCard
                                    id={item.Id}
                                    header={item.Name}
                                    onDelete={DeleteClick}
                                    ImgUrl={item.ImgUrl}
                                    onView={ViewClick}
                                ></VenderCard>
                            </div>
                        )
                    })
                }
            </div>

        </>
    )
}
function VenderCard(props) {


    const header = (
        <img alt="Card" src={props.ImgUrl} />
    );
    const footer = (
        <>
            <Button label="View" onClick={() => props.onView(props.id)} icon="pi pi-eye" />
            <Button label="Edit" severity="secondary" icon="pi pi-pencil" style={{ marginLeft: '0.5em' }} />
            <Button label="Delete" onClick={() => props.onDelete(props.id)} severity="danger" icon="pi pi-trash" style={{ marginLeft: '0.5em' }} />
        </>
    );
    return (
        <Card title={props.header} subTitle={props.id} footer={footer} header={header} className="md:w-25rem">
            <p className="m-0">
                Lorem ipsum dolor sit amet, consectetur adipisicing elit. Inventore sed consequuntur error repudiandae
                numquam deserunt quisquam repellat libero asperiores earum nam nobis, culpa ratione quam perferendis esse, cupiditate neque quas!
            </p>
        </Card>
    )
}


function ViewVender(props) {

    const footerContent = (
        <div>
            <Button label="No" icon="pi pi-times" onClick={() => alert(false)} className="p-button-text" />
            <Button label="Yes" icon="pi pi-check" onClick={() => alert(false)} autoFocus />
        </div>
    );
    const [vender, setVender] = useState(venderService.GetVenderDetails())
    return (
        <div className="card flex justify-content-center">
            <Dialog header={vender.Name} visible={props.visible} style={{ width: '50vw' }} onHide={() => props.onHide(false)} >
                <img alt="Card" src={vender.ImgUrl} />
                Lorem, ipsum dolor sit amet consectetur adipisicing elit. Maiores odit illum sit!
            </Dialog>
        </div>
    )
}