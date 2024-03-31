import React, { useState, useEffect } from 'react';
import axios from 'axios';

function Home() {
    const [chuyenXe, setChuyenXe] = useState(() => []);

    useEffect(() => {
        axios.get('https://localhost:7285/api/Futabus')
            .then(response => {
                setChuyenXe(response.data);
                console.log(response.data);
            })
            .catch(error => {
                console.error(error);
            });
    }, []);

    return (
        <table className="table table-striped">
            <thead>
                <tr>
                    <th scope="col">#</th>
                    <th scope="col">Tên Chuyến Xe</th>
                </tr>
            </thead>
            <tbody>
                {
                    chuyenXe.map((cx) =>
                    (
                        <tr>
                            <th key={cx.maChuyenXe} scope="row">{cx.maChuyenXe}</th>
                            <td>{cx.tenChuyenXe}</td>
                        </tr>
                    )
                    )
                }
            </tbody>
        </table>
    );
}

export default Home;